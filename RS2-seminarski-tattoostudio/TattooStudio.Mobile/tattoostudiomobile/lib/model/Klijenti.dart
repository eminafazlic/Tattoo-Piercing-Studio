import 'package:flutter/material.dart';

import 'Spolovi.dart';

class Klijenti {
  int? klijentId;
  String? ime;
  String? prezime;
  DateTime? datumRodjenja;
  String? email;
  String? telefon;
  String? korisnickoIme;
  String? lozinka;
  int? spolId;

  Klijenti(
  {this.klijentId,
  this.ime,
  this.prezime,
  this.datumRodjenja,
  this.email,
  this.telefon,
  this.korisnickoIme,
  this.lozinka,
  this.spolId});

  factory Klijenti.fromJson(Map<String, dynamic> json) {
    return Klijenti(
        klijentId: json['klijentid'] as int,
        ime: json['ime'] as String,
        prezime: json['prezime'] as String,
        datumRodjenja: DateTime.tryParse(json['datumRodjenja']),
        email: json['email'] as String,
        telefon: json['telefon'] as String,
        korisnickoIme: json['korisnickoIme'] as String,
        lozinka: json['lozinka'] as String,
        spolId: json['spolId'] as int);
        //spol: Spolovi.fromJson(json['spol']));
  }

  Map<String, dynamic> toJson() => {
    "id": klijentId,
    "ime": ime,
    "prezime": prezime,
    "datumRodjenja": datumRodjenja == null ? null : datumRodjenja!.toIso8601String(),
    "email": email,
    "telefon": telefon,
    "korisnickoIme": korisnickoIme,
    "lozinka":lozinka,
    "spolId":spolId
    //"spol": spol!.toJson()
  };
}