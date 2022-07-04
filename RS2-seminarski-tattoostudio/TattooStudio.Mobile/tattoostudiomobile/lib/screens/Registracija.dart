import 'package:flutter/material.dart';

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
  TextEditingController spolController = new TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: ListView(
      children: [
        Padding(
          padding: EdgeInsets.all(60),
          child: Column(
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
              TextField(
                controller: imeController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15),
                        borderSide: BorderSide(color: Colors.blue)),
                    hintText: 'Ime'),
              ),
              SizedBox(
                height: 7,
              ),
              TextField(
                controller: prezimeController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15),
                        borderSide: BorderSide(color: Colors.blue)),
                    hintText: 'Prezime'),
              ),
              SizedBox(
                height: 7,
              ),
              TextField(
                controller: emailController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15),
                        borderSide: BorderSide(color: Colors.blue)),
                    hintText: 'Email'),
              ),
              SizedBox(
                height: 7,
              ),
              TextField(
                controller: telefonController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15),
                        borderSide: BorderSide(color: Colors.blue)),
                    focusColor: Colors.blue,
                    hintText: 'Telefon'),
              ),
              SizedBox(
                height: 7,
              ),
              TextField(
                controller: korisnickoImeController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15),
                        borderSide: BorderSide(color: Colors.blue)),
                    hintText: 'Korisničko ime'),
              ),
              SizedBox(
                height: 7,
              ),
              TextField(
                controller: lozinkaController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15),
                        borderSide: BorderSide(color: Colors.blue)),
                    hintText: 'Lozinka'),
              ),
              SizedBox(
                height: 7,
              ),
              TextField(
                controller: potvrdaLozinkeController,
                decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15),
                        borderSide: BorderSide(color: Colors.blue)),
                    hintText: 'Potvrdite lozinku'),
              ),
              SizedBox(
                height: 7,
              ),
              //datum i combobox

              Container(
                height: 60,
                width: 300,
                decoration: BoxDecoration(
                    color: Colors.blue,
                    borderRadius: BorderRadius.circular(15)),
                child: TextButton(
                  onPressed: () async {
                    // APIService.username = korisnickoImeController.text;
                    // APIService.password = lozinkaController.text;
                    Navigator.of(context).pushReplacementNamed('/home');
                  },
                  child: Text(
                    'Registracija',
                    style: TextStyle(color: Colors.white, fontSize: 20),
                  ),
                ),
              )
            ],
          ),
        ),
      ],
    ));
  }
}
