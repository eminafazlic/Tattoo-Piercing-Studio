import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class Pocetna extends StatefulWidget {
  const Pocetna({Key? key}) : super(key: key);

  @override
  _PocetnaState createState() => _PocetnaState();
}

class _PocetnaState extends State<Pocetna> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Center(
      child: Padding(
          padding: EdgeInsets.all(60),
          child: Column(mainAxisAlignment: MainAxisAlignment.center, children: [
            Image(image: AssetImage('assets/images/tattoostudiologo.png')),
            SizedBox(height: 10),
            Container(
              height: 60,
              width: 300,
              decoration: BoxDecoration(
                  color: Colors.blue[700],
                  borderRadius: BorderRadius.circular(15)),
              child: TextButton(
                  onPressed: () async {
                    Navigator.of(context).pushReplacementNamed('/registracija');
                  },
                  child: Text('Registrujte se',
                      style: TextStyle(color: Colors.white, fontSize: 20))),
            ),
            SizedBox(height: 10),
            Container(
              height: 60,
              width: 300,
              decoration: BoxDecoration(
                  color: Colors.blue[700],
                  borderRadius: BorderRadius.circular(15)),
              child: TextButton(
                  onPressed: () async {
                    Navigator.of(context).pushReplacementNamed('/login');
                  },
                  child: Text('Prijavite se',
                      style: TextStyle(color: Colors.white, fontSize: 20))),
            )
          ])),
    ));
  }
}
