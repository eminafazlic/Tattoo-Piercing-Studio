import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Uposlenici.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'package:tattoostudiomobile/screens/DetaljiStavkePortfolija.dart';

//prikazati podatke artista i slike njegovih radova tj sve stavke njegovog portfolija


class PortfolioDetalji extends StatefulWidget {
  final Uposlenici? uposlenik;
  const PortfolioDetalji({Key? key, this.uposlenik}) : super(key: key);

  @override
  _PortfolioDetaljiState createState() => _PortfolioDetaljiState();
}

class _PortfolioDetaljiState extends State<PortfolioDetalji> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('Portfolio uposlenika'),
          backgroundColor: Colors.blue,
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return Text(
        "handled this very... gracefully"); }

  /*  return FutureBuilder<dynamic>(
        future: GetPortfolio(),
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
              return ListView(
                children:
                snapshot.data.map<Widget>((e)=>PortfolioWidget(e)).toList(),
          );
            }
          }
        });
  }

   Future<dynamic> GetPortfolio() async {
    var portfolio = await APIService.GetById('Portfolio', uposlenik!.uposlenikId);
    return portfolio!.map((i) => Uposlenici.fromJson(i)).toList();
  }

  Widget PortfolioWidget(stavka) {
    return Card(
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) =>
                      DetaljiStavkePortfolija(stavka: stavka)));
        },
        child:
            Padding(padding: EdgeInsets.all(20), child: Text(stavka.)),
      ),
    );
  }
}*/
}