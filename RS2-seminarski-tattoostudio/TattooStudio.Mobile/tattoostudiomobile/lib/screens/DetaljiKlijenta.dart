import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Klijenti.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'Pocetna.dart';


class DetaljiKlijenta extends StatefulWidget {
  const DetaljiKlijenta({Key? key}) : super(key: key);

  @override
  _DetaljiKlijentaState createState() => _DetaljiKlijentaState();
}

class _DetaljiKlijentaState extends State<DetaljiKlijenta> {
  Klijenti korisnik = Klijenti();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text("Moj profil")),
      body: body(),
    );
  }

  Widget body() {
    dynamic response;
    Klijenti request = Klijenti();

    const _obaveznoPolje = "Polje je obavezno";

    TextStyle style = const TextStyle(fontSize: 18.0);

    TextEditingController imeController = TextEditingController();
    TextEditingController prezimeController = TextEditingController();
    TextEditingController emailController = TextEditingController();
    TextEditingController dtpDatumRodjenjaController = TextEditingController();
    TextEditingController korisnickoImeController = TextEditingController();
    TextEditingController lozinkaController = TextEditingController();
    DateTime _odabraniDatumRodjenja = DateTime.now();

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
          dtpDatumRodjenjaController.text =
              "${_odabraniDatumRodjenja.toLocal()}".split(' ')[0];
        });
      }
    }

    Future<void> sendRequest(Klijenti request) async {
      response = await APIService.Put("Klijent/update", APIService.klijentId!,
          json.encode(request.toJson()));
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
        } else {
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

    final dtpDatumRodjenja = InkWell(
      child: IgnorePointer(
        child: TextFormField(
          validator: (value) {
            return value == null || value.isEmpty ? _obaveznoPolje : null;
          },
          controller: dtpDatumRodjenjaController,
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

    final btnOdustani = Material(
      elevation: 5.0,
      borderRadius: BorderRadius.circular(30.0),
      color: Colors.white,
      child: MaterialButton(
        padding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
        onPressed: () async {
          Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(
              builder: (BuildContext context) => const Pocetna(),
            ),
            (route) => false,
          );
        },
        child: Text("Odustani",
            textAlign: TextAlign.center,
            style: style.copyWith(
                color: const Color(0xff01A0C7), fontWeight: FontWeight.bold)),
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
            request.ime = imeController.text;
            request.prezime = prezimeController.text;
            request.email = emailController.text;
            request.datumRodjenja = _odabraniDatumRodjenja;
            request.spolId = _odabraniSpol;
            request.korisnickoIme = korisnickoImeController.text;
            request.lozinka = lozinkaController.text;

            if (request.lozinka == null || request.lozinka!.isEmpty) {
              request.lozinka = APIService.lozinka!;
            }

            await sendRequest(request);
            if (response == null) {
              _showDialog('Došlo je do greške, pokušajte opet! ');
            } else {
              //i dont even know
            }
          }
        },
        child: Text("Spremi izmjene",
            textAlign: TextAlign.center,
            style: style.copyWith(
                color: Colors.white, fontWeight: FontWeight.bold)),
      ),
    );

    Widget ddSpol() {
      return DropdownButtonFormField<dynamic>(
        validator: (value) {
          return value == null || value.isEmpty ? _obaveznoPolje : null;
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

    return FutureBuilder(
      future: getKorisnik(APIService.klijentId),
      builder: (BuildContext context, AsyncSnapshot snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text("Loading..."));
        } else if (snapshot.hasError) {
          return const Center(child: Text("Greška pri učitavanju."));
        } else {
          imeController.text = korisnik.ime!;
          prezimeController.text = korisnik.prezime!;
          emailController.text = korisnik.email!;
          _odabraniDatumRodjenja = korisnik.datumRodjenja!;
          dtpDatumRodjenjaController.text =
              "${_odabraniDatumRodjenja.toLocal()}".split(' ')[0];
          _odabraniSpol = korisnik.spolId!;
          korisnickoImeController.text = korisnik.korisnickoIme!;
          //lozinkaController.text = korisnik.lozinka!;
          imeController.text = korisnik.ime!;

          return Center(
            child: Container(
              color: Colors.white,
              child: Padding(
                padding: const EdgeInsets.all(36.0),
                child: Column(
                    crossAxisAlignment: CrossAxisAlignment.center,
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Form(
                        key: _formKey,
                        autovalidateMode: AutovalidateMode.onUserInteraction,
                        child: Column(
                            crossAxisAlignment: CrossAxisAlignment.center,
                            mainAxisAlignment: MainAxisAlignment.center,
                            children: [
                              //Ime i prezime
                              Row(
                                children: [
                                  Flexible(child: txtIme),
                                  const SizedBox(
                                    width: 5.0,
                                  ),
                                  Flexible(child: txtPrezime)
                                ],
                              ),
                              const SizedBox(height: 5.0),
                              txtMail,
                              const SizedBox(height: 5.0),
                              //Datum rodjenja i spol
                              Row(
                                children: [
                                  Flexible(child: dtpDatumRodjenja),
                                  const SizedBox(
                                    width: 5.0,
                                  ),
                                  Flexible(child: ddSpol())
                                ],
                              ),
                              const SizedBox(height: 5.0),
                              //Korisnicko ime i lozinka
                              Row(
                                children: [
                                  Flexible(child: txtKorisnickoIme),
                                  const SizedBox(
                                    width: 5.0,
                                  ),
                                  Flexible(child: txtLozinka)
                                ],
                              ),
                              const SizedBox(height: 15.0),
                              //Buttoni
                              Row(
                                  crossAxisAlignment: CrossAxisAlignment.center,
                                  mainAxisAlignment: MainAxisAlignment.center,
                                  children: [
                                    btnOdustani,
                                    const SizedBox(width: 15.0),
                                    Expanded(child: btnSpremiIzmjene)
                                  ]),
                            ]),
                      ),
                    ]),
              ),
            ),
          );
        }
        // else {
        //   return const Center(
        //     child: Text("Došlo je do greške!"),
        //   );
        // }
      },
    );
  }

  Future<dynamic> getKorisnik(int? korisnikId) async {
    var response = await APIService.GetById("Klijent", korisnikId!);
    return response;
  }
}



//pokušaj prvi:

//   Klijenti klijent = Klijenti();
//   TextEditingController korisnickoImeController = new TextEditingController();
//   TextEditingController lozinkaController = new TextEditingController();
//   TextEditingController potvrdaLozinkeController = new TextEditingController();
//   TextEditingController imeController = new TextEditingController();
//   TextEditingController prezimeController = new TextEditingController();
//   DateTime datumRodjenjaController = DateTime.now();
//   TextEditingController emailController = new TextEditingController();
//   TextEditingController telefonController = new TextEditingController();
//   TextEditingController spolController = new TextEditingController();
//   List<DropdownMenuItem> spolovi = [
//     DropdownMenuItem(
//         child: Text(
//           "Muški",
//           style: TextStyle(fontSize: 13, color: Colors.grey[600]),
//         ),
//         value: 'M'),
//     DropdownMenuItem(
//         child: Text(
//           "Ženski",
//           style: TextStyle(fontSize: 18.0, color: Colors.grey[600]),
//         ),
//         value: 'Ž'),
//     DropdownMenuItem(
//         child: Text(
//           "Ostalo",
//           style: TextStyle(fontSize: 18.0, color: Colors.grey[600]),
//         ),
//         value: 'O'),
//   ];
//   String? odabraniSpol;
//   var result = null;
//   Future<void> GetData() async {
//     result = await APIService.GetById('Klijent', APIService.klijentId);
//   }
//
//   @override
//   Widget build(BuildContext context) {
//     return Scaffold(
//         body: ListView(
//       children: [
//         Padding(
//           padding: EdgeInsets.all(60),
//           child: Column(mainAxisAlignment: MainAxisAlignment.center, children: [
//             TextField(
//               controller: imeController,
//               decoration: InputDecoration(
//                   border: OutlineInputBorder(
//                       borderRadius: BorderRadius.circular(15),
//                       borderSide: BorderSide(color: Colors.blue)),
//                   hintText: 'Ime'),
//             ),
//             SizedBox(
//               height: 7,
//             ),
//             TextField(
//               controller: prezimeController,
//               decoration: InputDecoration(
//                   border: OutlineInputBorder(
//                       borderRadius: BorderRadius.circular(15),
//                       borderSide: BorderSide(color: Colors.blue)),
//                   hintText: 'Prezime'),
//             ),
//             SizedBox(
//               height: 7,
//             ),
//             TextField(
//               controller: emailController,
//               decoration: InputDecoration(
//                   border: OutlineInputBorder(
//                       borderRadius: BorderRadius.circular(15),
//                       borderSide: BorderSide(color: Colors.blue)),
//                   hintText: 'Email'),
//             ),
//             SizedBox(
//               height: 7,
//             ),
//             TextField(
//               controller: telefonController,
//               decoration: InputDecoration(
//                   border: OutlineInputBorder(
//                       borderRadius: BorderRadius.circular(15),
//                       borderSide: BorderSide(color: Colors.blue)),
//                   focusColor: Colors.blue,
//                   hintText: 'Telefon'),
//             ),
//             SizedBox(
//               height: 7,
//             ),
//             TextField(
//               controller: korisnickoImeController,
//               decoration: InputDecoration(
//                   border: OutlineInputBorder(
//                       borderRadius: BorderRadius.circular(15),
//                       borderSide: BorderSide(color: Colors.blue)),
//                   hintText: 'Korisničko ime'),
//             ),
//             SizedBox(
//               height: 7,
//             ),
//             TextField(
//               controller: lozinkaController,
//               decoration: InputDecoration(
//                   border: OutlineInputBorder(
//                       borderRadius: BorderRadius.circular(15),
//                       borderSide: BorderSide(color: Colors.blue)),
//                   hintText: 'Lozinka'),
//             ),
//             SizedBox(
//               height: 7,
//             ),
//             TextField(
//               controller: potvrdaLozinkeController,
//               decoration: InputDecoration(
//                   border: OutlineInputBorder(
//                       borderRadius: BorderRadius.circular(15),
//                       borderSide: BorderSide(color: Colors.blue)),
//                   hintText: 'Potvrdite lozinku'),
//             ),
//             SizedBox(
//               height: 7,
//             ),
//
//             //date picker i combobox za spol tu
//
//             Container(
//               height: 60,
//               width: 300,
//               decoration: BoxDecoration(
//                   color: Colors.blue, borderRadius: BorderRadius.circular(15)),
//               child: TextButton(
//                 onPressed: () async {
//                   APIService.korisnickoIme = korisnickoImeController.text;
//                   APIService.lozinka = lozinkaController.text;
//                   await GetData();
//                   if (result != null) {
//                     print(result);
//                     Navigator.of(context).pushReplacementNamed('/home');
//                   }
//                 },
//                 child: Text(
//                   'Spremi',
//                   style: TextStyle(color: Colors.white, fontSize: 20),
//                 ),
//               ),
//             ),
//             SizedBox(height: 20),
//             Container(
//               height: 60,
//               width: 300,
//               decoration: BoxDecoration(
//                   color: Colors.blue, borderRadius: BorderRadius.circular(20)),
//               child: TextButton(
//                 onPressed: () async {
//                   Navigator.of(context).pushReplacementNamed('/pocetna');
//                 },
//                 child: Text(
//                   'Obriši račun',
//                   style: TextStyle(color: Colors.red, fontSize: 20),
//                 ),
//               ),
//             ),
//           ]),
//         )
//       ],
//     ));
//   }
// }
