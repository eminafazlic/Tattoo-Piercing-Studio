import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:tattoostudiomobile/model/Obavijesti.dart';

class DetaljiObavijesti extends StatelessWidget {
  final Obavijesti? obavijest;
  DetaljiObavijesti({Key? key, this.obavijest}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text(
            'Obavijest',
          ),
          backgroundColor: Colors.blue,
        ),
        body: Padding(
            padding: const EdgeInsets.all(20),
            child: Column(
                crossAxisAlignment: CrossAxisAlignment.stretch,
                children: [
                  Text(
                    obavijest!.naslov!,
                    style: const TextStyle(
                        fontSize: 30, fontWeight: FontWeight.w500),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(
                    height: 20,
                  ),
                  Text(
                    obavijest!.sadrzaj!,
                    style:
                        TextStyle(fontSize: 25.0, fontWeight: FontWeight.w300),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(height: 60.0),
                  Text(
                    "Datum objave: ${DateFormat('dd/MM/yyyy').format(obavijest!.datum!)}",
                    style:
                        TextStyle(fontSize: 15.0, fontWeight: FontWeight.w300),
                    textAlign: TextAlign.center,
                  ),
                ])));
  }
}
