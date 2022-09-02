import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Klijenti.dart';
import 'package:tattoostudiomobile/model/Narudzbe.dart';
import 'package:tattoostudiomobile/model/Proizvodi.dart';
import 'package:tattoostudiomobile/model/StavkeNarudzbe.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'package:tattoostudiomobile/providers/Payment.dart';
import 'package:tattoostudiomobile/screens/DetaljiProizvoda.dart';

class Narudzba extends StatefulWidget {
  Narudzbe? narudzba;
  Narudzba({ Key? key, this.narudzba}) : super(key: key);

  @override
  State<Narudzba> createState() => _NarudzbaState();
}

class _NarudzbaState extends State<Narudzba> {
  List<dynamic>? _stavkeNarudzbe = [];
  Narudzbe? narudzba;
  Future<List<dynamic>?> getNarudzbaStavke() async {
    var response = await APIService.GetById("Narudzba", APIService.aktivnaNarudzba, null);
    narudzba= new Narudzbe.fromJson(response); //
    Map<String, dynamic> queryParams = {'NarudzbaId': APIService.aktivnaNarudzba.toString()};
    var stavke = await APIService.Get("StavkeNarudzbe", queryParams);
    if(stavke != null) {
      stavke.map((i)=>StavkeNarudzbe.fromJson(i)).toList();
      _stavkeNarudzbe = stavke;
    }
    return _stavkeNarudzbe;
  }

  Future<void> UkloniStavku(int id) async {
    await APIService.Delete("StavkeNarudzbe", id);
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
    return 
      Scaffold(
      appBar: AppBar(
        title: Text('Vaša korpa'),
        backgroundColor: Colors.blue,
      ),
      body: FutureBuilder<dynamic>(
        future: getNarudzbaStavke(),
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
            } else
                return SingleChildScrollView(
                  child: Padding(
                  padding: const EdgeInsets.all(30),
                  child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: [
                    Text(
                    'Vaša trenutna narudžba',
                      style: const TextStyle(
                        fontSize: 18, fontWeight: FontWeight.w500, color: Colors.blue),
                    textAlign: TextAlign.center,),
                  const SizedBox(
                    height: 26,
                  ),
                  Text(
                    'Ukupni iznos: ${narudzba!.ukupniIznos}\nPlaćeno: ${narudzba!.IsPlacena}\nIsporučeno: ${narudzba!.isIsporucena}',
                      style: const TextStyle(
                        fontSize: 16, fontWeight: FontWeight.w400, color: Colors.blue),
                    textAlign: TextAlign.center,),
                  const SizedBox(
                    height: 26,
                  ),
                  ListView(
                    shrinkWrap:true,
                  children: 
                  _stavkeNarudzbe!.map((e) => new Card(
                    child: TextButton(
                    onPressed: () {
                      UkloniStavku(e['stavkeNarudzbeId']);
                    },
                      child: Padding(
                      padding: EdgeInsets.all(15),
                      child: Text("Stavka narudžbe ${e['proizvodId']}\nKoličina ${e['kolicina']}\n(klikni da ukloniš)")))))
                      .toList()
                      ),
                      if(_stavkeNarudzbe!.isNotEmpty) TextButton(
                        onPressed: () async {
                            payWithCard(amount:narudzba!.ukupniIznos!);
                            Map<String, dynamic> request = {
                              'IsPlacena': true, 
                              'klijentId': APIService.klijentId,
                              'datum': narudzba!.datum!.toIso8601String(),
                              'ukupniIznos': narudzba!.ukupniIznos,
                              'isIsporucena': narudzba!.isIsporucena
                              };
                            await APIService.Put("Narudzba", APIService.aktivnaNarudzba!, jsonEncode(request));
                        },
                      child: Text('Naruči/plati',
                      style: TextStyle(color: Colors.blue, fontSize: 20))
                      )
                      ]
                      )));}})
    );
  }
}