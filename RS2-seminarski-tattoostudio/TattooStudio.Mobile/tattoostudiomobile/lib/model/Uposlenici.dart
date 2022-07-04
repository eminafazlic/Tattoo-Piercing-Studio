import 'dart:convert';
import 'package:tattoostudiomobile/model/Zanimanja.dart';
import 'Spolovi.dart';

class Uposlenici{
  int? uposlenikId;
  String? ime;
  String? prezime;
  String? email;
  String? telefon;
  String? korisnickoIme;
  List<int>? slika;
  //Zanimanja? zanimanje;
  //Spolovi? spol;

  Uposlenici({
    this.uposlenikId,
    this.ime,
    this.prezime,
    this.email,
    this.telefon,
    this.korisnickoIme,
    this.slika,
    //this.zanimanje,
    //this.spol
});

  factory Uposlenici.fromJson(Map<String, dynamic> json){
    String stringByte = json['slika'] as String;
    List<int>bytes=base64.decode(stringByte);
    return Uposlenici(
        uposlenikId: json['uposlenikId'] as int,
        ime: json['ime'] as String,
        prezime: json['prezime'] as String,
        email: json['email'] as String,
        telefon: json['telefon'] as String,
        slika: bytes,
        korisnickoIme: json['korisnickoIme'] as String,
        //zanimanje: Zanimanja.fromJson(json['zanimanje']),
        //spol: Spolovi.fromJson(json['spol'])
    );
  }

  Map<String, dynamic> toJson() => {
    "uposlenikId": uposlenikId,
    "ime": ime,
    "prezime": prezime,
    "email": email,
    "telefon": telefon,
    "slika":slika,
    "korisnickoIme": korisnickoIme,
    //"zanimanje": zanimanje!.toJson(),
    //"spol": spol!.toJson()
  };
}