
import 'dart:convert';
import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Narudzbe.dart';
import 'package:tattoostudiomobile/model/Proizvodi.dart';
import 'package:tattoostudiomobile/model/StavkeNarudzbe.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'package:tattoostudiomobile/screens/Narudzba.dart';
import 'SviProizvodi.dart';

class DetaljiProizvoda extends StatelessWidget {
  final Proizvodi? proizvod;
  DetaljiProizvoda({Key? key, this.proizvod}) : super(key: key);

  List<dynamic>? _recommendedProizvodi = [];
  Future<List<dynamic>?> getRecommendedProizvodi() async {
    var recommended = await APIService.Get("Proizvod/Recommend/${proizvod!.proizvodId}", null);
    if(recommended != null)
    {
      recommended.map((i)=>Proizvodi.fromJson(i)).toList();
      _recommendedProizvodi = recommended;
    }

    
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          'Detalji proizvoda',
          style: TextStyle(fontSize: 20),
        ),
        backgroundColor: Colors.blue,
      ),
      body: FutureBuilder<dynamic>(
        future: getRecommendedProizvodi(),
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
            } else {
              return SingleChildScrollView(
      child: Column(
        children: [
          Center(
            child: Image(
                height: 160,
                width: 160,
                image: /*Image.memory(Uint8List.fromList(proizvod!.slika!)).image, 
                errorBuilder: (context, error, stackTrace) => Image.asset("assets/images/error.jpg"))*/
                AssetImage('assets/images/imgplaceholder.jpg')
            )
          ),
          Text(
            proizvod!.naziv!,
            style: TextStyle(fontSize: 25),
          ),
          Text(
            proizvod!.cijena! + ' KM',
            style: TextStyle(fontSize: 20),
          ),
          Text(
            proizvod!.opis!,
            style: TextStyle(fontSize: 17),
          ),
          Padding(
              padding: EdgeInsets.all(30),
              child: TextButton(
                onPressed: () async {
                  var response = await APIService.GetById("Narudzba", APIService.aktivnaNarudzba, null);
                  Narudzbe narudzba= new Narudzbe.fromJson(response);
                  if(narudzba.IsPlacena==false && narudzba.isIsporucena==false)
                  {
                    Map<String, dynamic> insertRequest = { 'narudzbaId': APIService.aktivnaNarudzba, 'proizvodId': proizvod!.proizvodId, 'kolicina': 1};
                    await APIService.Post("StavkeNarudzbe", jsonEncode(insertRequest));
                  }
                },
                child: Image(
                    width: 40,
                    height: 40,
                    image: AssetImage('assets/images/korpa.png')),
              )),
              SizedBox(height: 20,),
              Text("Broj prodanih proizvoda je"),
              SizedBox(height: 20,),
              Text("Korisnicima se svidjelo još i...", style: TextStyle(color: Colors.blueGrey, fontSize: 16)),
              SizedBox(height: 20,),
              if(_recommendedProizvodi != "[]")
              ListView(
                shrinkWrap:true,
                  children: 
                  _recommendedProizvodi!.map((e) => new Card(
                    child: TextButton(
                    onPressed: () {
                    Navigator.push(
                    context,
                    MaterialPageRoute(
                    builder: (context) => DetaljiProizvoda(proizvod: new Proizvodi.fromJson(e))));},
                      child: Padding(
                      padding: EdgeInsets.all(15),
                      child: Text("${e['proizvodId']} ${e['naziv']}")))))
                      .toList()
                      ) 
                  ]));
                }}}
              ));
            }}
