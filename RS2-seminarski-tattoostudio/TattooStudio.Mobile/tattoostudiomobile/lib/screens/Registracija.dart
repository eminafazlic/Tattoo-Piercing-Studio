import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Klijenti.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'package:tattoostudiomobile/screens/Home.dart';
import 'package:tattoostudiomobile/screens/Login.dart';
import 'package:tattoostudiomobile/screens/Pocetna.dart';

class Registracija extends StatefulWidget {
  const Registracija({Key? key}) : super(key: key);

  @override
  _RegistracijaState createState() => _RegistracijaState();
}

class _RegistracijaState extends State<Registracija> {
  TextEditingController korisnickoImeController = new TextEditingController();
  TextEditingController lozinkaController = new TextEditingController();
  TextEditingController potvrdaLozinkeController = new TextEditingController();
  TextEditingController imeController = new TextEditingController();
  TextEditingController prezimeController = new TextEditingController();
  TextEditingController datumRodjenjaController = new TextEditingController();
  TextEditingController emailController = new TextEditingController();
  TextEditingController telefonController = new TextEditingController();
  //TextEditingController spolController = new TextEditingController();
  DateTime _odabraniDatumRodjenja = DateTime(2000, 1);
  dynamic response;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: body()
    );
  }
  Widget body() {
    const _obaveznoPolje = "Polje je obavezno";
    TextStyle style = const TextStyle(fontSize: 18.0);
    List<DropdownMenuItem> spolovi = [
      DropdownMenuItem(
          child: Text(
            "Muški",
            style: TextStyle(fontSize: 18.0, color: Colors.grey[600]),
          ),
          value: 1),
      DropdownMenuItem(
          child: Text(
            "Ženski",
            style: TextStyle(fontSize: 18.0, color: Colors.grey[600]),
          ),
          value: 2),
      DropdownMenuItem(
          child: Text(
            "Ostalo",
            style: TextStyle(fontSize: 18.0, color: Colors.grey[600]),
          ),
          value: 3),
    ];
    int? _odabraniSpol;

    final _formKey = GlobalKey<FormState>();
    Future<void> _selectDate(BuildContext context) async {
      final DateTime? picked = await showDatePicker(
          context: context,
          initialDate: _odabraniDatumRodjenja,
          firstDate: DateTime(1900, 1),
          lastDate: DateTime.now());
      if (picked != null && picked != _odabraniDatumRodjenja) {
        setState(() {
          _odabraniDatumRodjenja = picked;
          datumRodjenjaController.text =
              "${_odabraniDatumRodjenja.toLocal()}".split(' ')[0];
        });
      }
    }

    Future<void> sendRequest(Map<String, dynamic> request) async {
      response = await APIService.Post("Klijent", jsonEncode(request));
    }

    Future<void> _showDialog(String text, [dismissable = true]) async {
      return showDialog<void>(
        barrierDismissible: dismissable,
        context: context,
        builder: (BuildContext context) {
          return AlertDialog(
            content: Text(text),
            actions: <Widget>[
              TextButton(
                child: const Text('OK'),
                onPressed: () {
                  Navigator.of(context).pushAndRemoveUntil(
                    MaterialPageRoute(
                      builder: (BuildContext context) => const Pocetna(),
                    ),
                    (route) => false,
                  );
                },
              ),
            ],
          );
        },
      );
    }

    final txtIme = TextFormField(
      validator: (value) {
        return value == null || value.isEmpty ? _obaveznoPolje : null;
      },
      controller: imeController,
      obscureText: false,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Ime",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );
    final txtPrezime = TextFormField(
      validator: (value) {
        return value == null || value.isEmpty ? _obaveznoPolje : null;
      },
      controller: prezimeController,
      obscureText: false,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Prezime",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );

    final txtMail = TextFormField(
      validator: (value) {
        if (value == null || value.isEmpty) {
          return _obaveznoPolje;
        } else if (!value.contains(RegExp(r'^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$'))) 
        { return "Unesite validnu email adresu! Format: abc@abc.com"; }
          else {
          return null;
        }
      },
      controller: emailController,
      obscureText: false,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Email",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );

      final txtTelefon = TextFormField(
      validator: (value) {
        if (value == null || value.isEmpty) {
          return _obaveznoPolje;
        } else if (!(RegExp(r'\d{3}\/\d{3}-\d{3,4}')).hasMatch(value))
        { return "Format: XXX/XXX-XXX ili XXX/XXX-XXXX"; }
        else {
          return null;
        }
      },
      controller: telefonController,
      obscureText: false,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Telefon",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );

    final dtpDatumRodjenja = InkWell(
      child: IgnorePointer(
        child: TextFormField(
          validator: (value) {
            return value == null || value.isEmpty ? _obaveznoPolje : null;
          },
          controller: datumRodjenjaController,
          obscureText: false,
          style: style,
          decoration: InputDecoration(
              contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
              hintText: "Datum rođenja",
              border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(32.0))),
        ),
      ),
      onTap: () {
        _selectDate(context);
      },
    );

    final txtKorisnickoIme = TextFormField(
      validator: (value) {
        return value == null || value.isEmpty ? _obaveznoPolje : null;
      },
      controller: korisnickoImeController,
      obscureText: false,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Korisničko ime",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );
    final txtLozinka = TextFormField(
      validator: (value) {
        if (value != null && value.isNotEmpty) {
          if (value.length < 5) {
            return "Minimalna dužina 5!";
          } else if (!value.contains(RegExp(r'[0-9]')) ||
              !value.contains(RegExp(r'[a-zA-Z]'))) {
            return "Obavezno jedno slovo i broj!";
          } else {
            return null;
          }
        }
      },
      controller: lozinkaController,
      obscureText: true,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Lozinka",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );
    final txtPotvrdiLozinku = TextFormField(
      validator: (value) {
        if (value != null && value.isNotEmpty) {
          if (value.length < 5) {
            return "Minimalna dužina 5!";
          } else if (!value.contains(RegExp(r'[0-9]')) ||
              !value.contains(RegExp(r'[a-zA-Z]'))) {
            return "Obavezno jedno slovo i broj!";
          } /*else if (value != txtLozinka)
            return "Lozinke se ne podudaraju!";*/
          else {
            return null;
          }
        }
      },
      controller: potvrdaLozinkeController,
      obscureText: true,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Potvrdite lozinku",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );

    final btnLogin = Material(
      elevation: 5.0,
      borderRadius: BorderRadius.circular(30.0),
      color: Colors.white,
      child: MaterialButton(
        padding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
        onPressed: () async {
          Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(
              builder: (BuildContext context) => const Login(),
            ),
            (route) => false,
          );
        },
        child: Text("Prijavite se",
            textAlign: TextAlign.center,
            style: style.copyWith(
                color: const Color(0xff01A0C7), fontWeight: FontWeight.normal)),
      ),
    );

    final btnSpremiIzmjene = Material(
      elevation: 5.0,
      borderRadius: BorderRadius.circular(30.0),
      color: const Color(0xff01A0C7),
      child: MaterialButton(
        padding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
        onPressed: () async {
          if (_formKey.currentState!.validate()) {
            response = null;
            Map<String, dynamic> request = {
              'ime': imeController.text,
              'prezime': prezimeController.text,
              'datumRodjenja': _odabraniDatumRodjenja.toIso8601String(),
              'email': emailController.text,
              'telefon': telefonController.text,
              'korisnickoIme': korisnickoImeController.text,
              'spolId': _odabraniSpol,
              'lozinka': lozinkaController.text,
              'potvrdiLozinku': potvrdaLozinkeController.text
            };
            if (lozinkaController.text == null || potvrdaLozinkeController.text == null) {
              print("nedostaje lozinka ok");
            }
            await sendRequest(request);
            if (response == null) {
              _showDialog('Došlo je do greške, pokušajte opet!');
            } else {
              _showDialog('Uspješno ste se registrovali!');
              await Future.delayed(Duration(seconds: 2));
              Navigator.of(context).pushReplacementNamed('/login');
            }
          }
        },
        child: Text("Registracija",
            textAlign: TextAlign.center,
            style: style.copyWith(
                color: Colors.white, fontWeight: FontWeight.bold)),
      ),
    );

    Widget ddSpol() {
      return DropdownButtonFormField<dynamic>(
        validator: (value) {
          return value == null /*|| value.isEmpty*/ ? _obaveznoPolje : null;
        },
        hint: Text(
          'Spol',
          style: TextStyle(fontSize: 18.0, color: Colors.grey[600]),
        ),
        isExpanded: true,
        items: spolovi,
        onChanged: (newVal) {
          _odabraniSpol = newVal;
        },
        value: _odabraniSpol,
        decoration: InputDecoration(
            contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
            border:
                OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
      );
    }

    return 
    ListView(
      children: [
        Padding(
          padding: EdgeInsets.all(60),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Form(key:_formKey,
              autovalidateMode:AutovalidateMode.onUserInteraction,
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
              Row(
                children: [
                  Image(
                    width: 100,
                    height: 100,
                    image: AssetImage('assets/images/tattoostudiologo.png'),
                  ),
                  Text(
                    'Tattoo studio',
                    style: TextStyle(fontSize: 22),
                  )
                ],
              ),
              SizedBox(
                height: 7,
              ),
              txtIme,
              SizedBox(
                height: 7,
              ),
              txtPrezime,
              SizedBox(
                height: 7,
              ),
              txtMail,
              SizedBox(
                height: 7,
              ),
              txtTelefon,
              SizedBox(
                height: 7,
              ),
              txtKorisnickoIme,
              SizedBox(
                height: 7,
              ),
              txtLozinka,
              SizedBox(
                height: 7,
              ),
              txtPotvrdiLozinku,
              SizedBox(
                height: 7,
              ),
              ddSpol(),
              SizedBox(height: 7,),
              dtpDatumRodjenja,
              SizedBox(height: 16,),
              Row(crossAxisAlignment: CrossAxisAlignment.center,
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    btnLogin,
                    const SizedBox(width: 15.0),
                    Expanded(child: btnSpremiIzmjene)]),
              SizedBox(height: 30),
            ],)
            )
            ]
            )
          ),]
        );
  }
}
