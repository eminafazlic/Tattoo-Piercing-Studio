// ignore: file_names
import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Proizvodi.dart';
import 'package:tattoostudiomobile/providers/CartService.dart';
import 'SviProizvodi.dart';

//ispod detalja o proizvodu bi trebalo prikazati preporučene proizvode
//api recommender dobiti listu prikazati je ispod

class DetaljiProizvoda extends StatelessWidget {
  final Proizvodi? proizvod;
  const DetaljiProizvoda({Key? key, this.proizvod}) : super(key: key);

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
      body: Column(
        children: [
          Center(
            child: Image(
                height: 300,
                width: 300,
                image: MemoryImage(proizvod!.slika as Uint8List)),
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
              padding: EdgeInsets.all(50),
              child: TextButton(
                onPressed: () {
                  CartService.AddProduct(proizvod!, 1);
                },
                child: Image(
                    width: 50,
                    height: 50,
                    image: AssetImage('assets/images/korpa.png')),
              ))
        ],
      ),
    );
  }
}
