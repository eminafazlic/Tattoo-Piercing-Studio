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
  bool _validateKorisnickoIme = false;
  bool _validateLozinka = false;
  Future<void> GetData() async {
    result = await APIService.prijava(korisnickoImeController.text, lozinkaController.text);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SingleChildScrollView(//Center(
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
                  hintText: 'Korisničko ime',
                  errorText: _validateKorisnickoIme ? 'Polje korisničko ime ne može biti prazno' : null),),
          SizedBox(
            height: 20,
          ),
          TextField(
            controller: lozinkaController,
            obscureText: true,
            autocorrect: false,
            decoration: InputDecoration(
                border:
                    OutlineInputBorder(borderRadius: BorderRadius.circular(15)),
                hintText: 'Lozinka',
                errorText: _validateLozinka ? 'Polje lozinka ne može biti prazno' : null,
                ),
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
                  setState(() {
                    korisnickoImeController.text.isEmpty ? _validateKorisnickoIme = true : _validateKorisnickoIme = false;
                    lozinkaController.text.isEmpty ? _validateLozinka = true : _validateLozinka = false;
                  });
                  APIService.korisnickoIme = korisnickoImeController.text;
                  APIService.lozinka = lozinkaController.text;
                  await GetData();
                  if (result != null) {
                    Navigator.of(context).pushReplacementNamed('/home');
                  }
                  else
                  {
                    if(_validateKorisnickoIme == false && _validateLozinka == false)
                    showDialog(context: context, builder: (BuildContext context) {return AlertDialog(
                      title: Text("Upozorenje"),
                      content: Text("Pogrešno korisničko ime ili lozinka"),
                      actions: [
                        TextButton(
                        child: Text("OK"),
                        onPressed: () { Navigator.of(context).pop(); },
                        ),
                        ],
                    );});
                  }
                },
                child: Text('Prijava',
                    style: TextStyle(color: Colors.white, fontSize: 20))),
                    ),
                    SizedBox(
            height: 20,
          ),


          Container(
            height: 60,
            width: 300,
            decoration: BoxDecoration(
                color: Colors.white,
                borderRadius: BorderRadius.circular(15)),
            child: TextButton(
              onPressed: () async {
                    Navigator.of(context).pushReplacementNamed('/registracija');
            }, child: Text('Registracija',
                    style: TextStyle(color: Colors.blue[700], fontSize: 20))),
                    ),
        ]),
      ),
    ));
  }
}
