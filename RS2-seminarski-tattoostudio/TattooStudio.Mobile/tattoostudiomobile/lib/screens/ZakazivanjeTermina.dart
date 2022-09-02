import 'dart:convert';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Termini.dart';
import 'package:tattoostudiomobile/model/Uposlenici.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'package:tattoostudiomobile/screens/Home.dart';
import 'package:tattoostudiomobile/screens/Pocetna.dart';

class ZakazivanjeTermina extends StatefulWidget {
  const ZakazivanjeTermina({Key? key}) : super(key: key);

  @override
  _ZakazivanjeTerminaState createState() => _ZakazivanjeTerminaState();
}

class _ZakazivanjeTerminaState extends State<ZakazivanjeTermina> {
  
    List<DropdownMenuItem<dynamic>>? _uposlenici = [];
    
    Future<void> getUposlenici() async {
      Map<String, String>? queryParams = null;
      if(_odabraniTipTermina==2)
      {
        queryParams={'zanimanjeId': '1'};
      }
      else if(_odabraniTipTermina==1)
      {
        queryParams={'SviTattooArtisti':'true'};
      }
      var uposlenici = await APIService.Get("Uposlenik", queryParams);
      uposlenici!.map((i)=>Uposlenici.fromJson(i)).toList();
      setState(() {
        _uposlenici = uposlenici
        .map((i) {
          return new DropdownMenuItem(child: 
          new Text("${i['ime']} ${i['prezime']}", style: TextStyle(fontSize: 13.0, color: Colors.grey[600]),),
          value: i['uposlenikId'],
          );
        }).toList();;
      });
    }
  @override
  void initState() {
    super.initState();
    //this.getUposlenici();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text("Zakazivanje termina")),
      body: body()
    );
  }
  
    TextEditingController dtpDatumController = TextEditingController();
    TextEditingController opisController = TextEditingController();
    DateTime odabraniDatum = DateTime.now().add(Duration(days:1));
    dynamic response;
    int? _odabraniTipTermina;
    int? _odabraniUposlenik;

  Widget body() {
    Map<String, dynamic> request;
    const _obaveznoPolje = "Polje je obavezno";
    TextStyle style = const TextStyle(fontSize: 16);
    List<DropdownMenuItem> tipTermina = [
      DropdownMenuItem(child: Text("Tattoo appointment",
      style: TextStyle(fontSize: 16, color: Colors.grey)),
      value: 1),
      DropdownMenuItem(child: Text("Piercing appointment",
      style: TextStyle(fontSize: 16, color: Colors.grey),),
      value: 2)
    ];
    final _formKey = GlobalKey<FormState>();
    Future<void> _selectDate(BuildContext context) async {
      final DateTime? picked = await showDatePicker(
        context: context,
        initialDate: odabraniDatum,
        firstDate: DateTime.now().add(Duration(days:1)),
        lastDate: DateTime(2025, 1));

      if(picked != null &&  picked != odabraniDatum) {
        setState(() {
          odabraniDatum = picked;
          dtpDatumController.text = "${odabraniDatum.toLocal()}".split(' ')[0];
        });
      }
    }
    Future<void> sendRequest(Map<String, dynamic> request) async {
      response = await APIService.Post("Termin", json.encode(request));
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
                      builder: (BuildContext context) => const Home(),
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
    final txtOpis = TextFormField(
      validator: (value) {
         if(value != null && value.isNotEmpty) 
         {
          if (value.length < 10) {
            return "Minimalna dužina je 10 znakova";
          } 
          else if (value.length > 200) {
            return "Maksimalna dužina je 200 znakova"; 
            } else {return null;}
      }},
      controller: opisController,
      obscureText: false,
      style: style,
      decoration: InputDecoration(
          contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
          hintText: "Opis zahtjeva",
          border:
              OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
    );
    final dtpDatum = InkWell(
      child: IgnorePointer(
        child: TextFormField(
          validator: (value) {
            return value == null || value.isEmpty ? _obaveznoPolje : null;
          },
          controller: dtpDatumController,
          obscureText: false,
          style: style,
          decoration: InputDecoration(
              contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
              hintText: "Datum termina",
              border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(32.0))),
        ),
      ),
      onTap: () {
        _selectDate(context);
      },
    );
  
    final btnZakazi = Material(
      elevation: 5.0,
      borderRadius: BorderRadius.circular(30.0),
      color: const Color(0xff01A0C7),
      child: MaterialButton(
        padding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
        onPressed: () async {
          if (_formKey.currentState!.validate()) {
            response = null;
            request = {'klijentId': APIService.klijentId, 'uposlenikId': _odabraniUposlenik, 
              'datum':odabraniDatum.toIso8601String(), 'opis':opisController.text, 'tipTerminaId':_odabraniTipTermina};
            await sendRequest(request);
            if (response == null) {
              _showDialog('Došlo je do greške, pokušajte opet');
            } else {
              _showDialog('Uspješno poslan novi zahtjev za terminom');
            }
          }
        },
        child: Text("Zakaži termin",
            textAlign: TextAlign.center,
            style: style.copyWith(
                color: Colors.white, fontWeight: FontWeight.bold)),
      ),
    );

    Widget ddTipTermina() {
      return DropdownButtonFormField<dynamic>(
        validator: (value) {
          return value == null /*|| value.isEmpty*/ ? _obaveznoPolje : null;
        },
        hint: Text(
          'Odaberite tip termina',
          style: TextStyle(fontSize: 13.0, color: Colors.grey[600]),
        ),
        isExpanded: true,
        items: tipTermina,
        onChanged: (newVal) {
          _odabraniTipTermina = newVal;
          getUposlenici();
        },
        value: _odabraniTipTermina,
        decoration: InputDecoration(
            contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
            border:
                OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
      );
    }

    Widget ddUposleni() {
      return DropdownButtonFormField<dynamic>(
        validator: (value) {
          return value == null /*|| value.isEmpty*/ ? _obaveznoPolje : null;
        },
        hint: Text(
          'Odaberite uposlenika kod kojeg zakazujete termin',
          style: TextStyle(fontSize: 13.0, color: Colors.grey[600]),
        ),
        isExpanded: true,
        items: _uposlenici,
        onChanged: (newVal) {
          _odabraniUposlenik = newVal;
        },
        value: _odabraniUposlenik,
        decoration: InputDecoration(
            contentPadding: const EdgeInsets.fromLTRB(20.0, 15.0, 20.0, 15.0),
            border:
                OutlineInputBorder(borderRadius: BorderRadius.circular(32.0))),
      );
    }

    return SingleChildScrollView(
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
                                  Row(
                                    children: [
                                      Flexible(child: txtOpis),
                                      const SizedBox(
                                        width: 5.0,
                                      )
                                    ],
                                  ),
                                  const SizedBox(height: 5.0),
                                  Row(
                                    children: [
                                      Flexible(child: dtpDatum),
                                      const SizedBox(
                                        width: 5.0,
                                      ),
                                      Flexible(child: ddTipTermina())
                                    ],
                                  ),
                                  const SizedBox(height: 5.0),
                                  Row(
                                    children: [
                                      Flexible(child: ddUposleni())
                                    ],
                                  ),
                                  const SizedBox(height: 5.0),
                                  Row(
                                      crossAxisAlignment: CrossAxisAlignment.center,
                                      mainAxisAlignment: MainAxisAlignment.center,
                                      children: [
                                        const SizedBox(width: 15.0),
                                        Expanded(child: btnZakazi)
                                      ]),
                                ]),
                          ),
                        ]),
                  ),
                ),
              );
          }
}
  //  );}}