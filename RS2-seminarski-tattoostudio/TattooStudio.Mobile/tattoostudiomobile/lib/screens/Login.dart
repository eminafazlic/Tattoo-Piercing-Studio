//import 'dart:js_util';

import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';

class Login extends StatefulWidget {
  const Login({Key? key}) : super(key: key);

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  TextEditingController korisnickoImeController = new TextEditingController();
  TextEditingController lozinkaController = new TextEditingController();
  var result;
  Future<void> GetData() async {
    result = await APIService.prijava(korisnickoImeController.text, lozinkaController.text);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Center(
      child: Padding(
        padding: EdgeInsets.all(60),
        child: Column(mainAxisAlignment: MainAxisAlignment.center, children: [
          Image(image: AssetImage('assets/images/tattoostudiologo.png')),
          SizedBox(height: 10),
          TextField(
              controller: korisnickoImeController,
              decoration: InputDecoration(
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(15),
                  ),
                  hintText: 'Korisničko ime')),
          SizedBox(
            height: 20,
          ),
          TextField(
            controller: lozinkaController,
            decoration: InputDecoration(
                border:
                    OutlineInputBorder(borderRadius: BorderRadius.circular(15)),
                hintText: 'Lozinka'),
          ),
          SizedBox(
            height: 20,
          ),
          Container(
            height: 60,
            width: 300,
            decoration: BoxDecoration(
                color: Colors.blue[700],
                borderRadius: BorderRadius.circular(15)),
            child: TextButton(
                onPressed: () async {
                  APIService.korisnickoIme = korisnickoImeController.text;
                  APIService.lozinka = lozinkaController.text;
                  await GetData();
                  if (result != null) {
                    Navigator.of(context).pushReplacementNamed('/home');
                  }
                },
                child: Text('Prijava',
                    style: TextStyle(color: Colors.white, fontSize: 20))),
          )
        ]),
      ),
    ));
  }
}
