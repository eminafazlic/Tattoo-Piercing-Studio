import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Termini.dart';
import 'package:tattoostudiomobile/providers/Payment.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';

class DetaljiTermina extends StatefulWidget {
  Termini? termin;
  DetaljiTermina({ Key? key, this.termin}) : super(key: key);

  @override
  State<DetaljiTermina> createState() => _DetaljiTerminaState();
}

class _DetaljiTerminaState extends State<DetaljiTermina> {

  Termini? termin;

  Future<dynamic> getTermin(int? korisnikId) async {
    var response = await APIService.GetById("Termin", APIService.klijentId!, "KlijentId=${APIService.klijentId}&NadolazeciTermini=true");
    if (response.isNotEmpty)
    {
      termin = Termini.fromJson(response[0]);
    }
    return response;
  }

  int getDaniDoTermina (DateTime datumTermina) {
    var danasnjiDatum = DateTime.now();
    return datumTermina.difference(danasnjiDatum).inDays;
  }

  void payWithCard({required int amount}) async{
    var response = 
    await StripeService.payWithNewCard(amount: amount.toString(), currency: 'BAM');
    final snackBar;
    print(response.message);
    if(response.message == 'Transaction cancelled'){
      snackBar = SnackBar(
        duration: Duration(
            milliseconds: response.success == false ? 1200 : 3000
        ),
        content: Text(response.success == true ? response.message : 'Transakcija otkazana'),
      );
    }
    else{
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Row(children: [
          CircularProgressIndicator(),
          Container(margin: EdgeInsets.only(left: 15),child:Text("Molimo pričekajte...")),
        ],),duration: Duration(seconds: 5),),
      );
      snackBar = SnackBar(
        duration: Duration(
            milliseconds: response.success == false ? 1200 : 3000
        ),
        content: Text(response.success == true ? response.message : 'Transakcija uspješna'),
      );
    }
    }



  @override
  void initState(){
    super.initState();
    StripeService.init();
  }
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('Nadolazeći termin'),
          backgroundColor: Colors.blue,
        ),
        body: FutureBuilder<dynamic>(
        future: getTermin(APIService.klijentId),
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(
              child: Text('Loading...'),
            );
          } else {
            if (snapshot.hasError) {
              return Center(
                child: Text('${snapshot.error}'),
              );
            } else if (termin==null){
              return Padding(
              padding: EdgeInsets.all(25),
              child: Text(
              'Trenutno nemate zakazane nikakve nadolazeće termine',
              style: const TextStyle(
              fontSize: 27, fontWeight: FontWeight.w400),
              textAlign: TextAlign.center,
              ));}
              else {
                return SingleChildScrollView(
              child: Padding(
              padding: const EdgeInsets.all(30),
              child: Column(
              crossAxisAlignment: CrossAxisAlignment.stretch,
                children: [
                  Text(
                    'Imate termin za ${getDaniDoTermina(termin!.datum!).toString()} dana!',
                    style: const TextStyle(
                        fontSize: 25, fontWeight: FontWeight.w500),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(
                    height: 20,
                  ),
                  Text(
                    'Datum vašeg nadolazećeg termina u našem studiju je ${termin!.datum!.toString()}',
                    style: const TextStyle(
                        fontSize: 20, fontWeight: FontWeight.w400),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(
                    height: 20,
                  ),
                  Text(
                    termin!.isPlacen == true ? 'Cijena iznosi ${termin!.cijena!.toString()}. Ovaj termin je plaćen.' : 'Cijena iznosi ${termin!.cijena!.toString()}. Ovaj termin nije plaćen.',
                    style:
                        TextStyle(fontSize: 20, fontWeight: FontWeight.w300),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(height: 20),
                  Text(
                    'Vaš zahtjev i opis termina: ${termin!.opis}',
                    style:
                        TextStyle(fontSize: 20, fontWeight: FontWeight.w300),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(height: 20),
                  if(termin!.isOtkazan == false) Text(
                    termin!.isOdobren == true ? 'Vaš termin je odobren' : 'Vaš termin još nije odobren.\nPlaćanje termina će biti moguće izvršiti nakon što uposlenik odobri termin.',
                    style:
                        TextStyle(fontSize: 20, color:Colors.blueGrey, fontWeight: FontWeight.w400),
                    textAlign: TextAlign.center,
                  ), 
                  const SizedBox(height: 20),
                  Text(
                    termin!.isOtkazan == true ? 'Vaš termin je otkazan. Komentar uposlenog: ${termin!.komentar}' : '',
                    style:
                        TextStyle(fontSize: 20, color: Colors.red, fontWeight: FontWeight.w500),
                    textAlign: TextAlign.center,
                  ), 
                  const SizedBox(height: 30),
                  if(termin!.isOdobren! && !termin!.isPlacen! && !termin!.isOtkazan!) ElevatedButton(
                    onPressed: () async {
                      payWithCard(amount:termin!.cijena!.toInt());
                    },
                    child: Text('Plati ovaj termin',
                    style: TextStyle(color: Colors.white, fontSize: 16),
                  ))])));
              }
            }}));
  }}