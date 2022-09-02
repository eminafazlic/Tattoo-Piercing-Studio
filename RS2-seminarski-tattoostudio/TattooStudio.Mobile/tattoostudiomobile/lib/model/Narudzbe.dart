import 'package:flutter/foundation.dart';
import 'package:tattoostudiomobile/model/StavkeNarudzbe.dart';

import 'Klijenti.dart';

class Narudzbe{
  int? narudzbaId;
  int? klijentId;
  DateTime? datum;
  int? ukupniIznos;
  bool? isIsporucena;        
  bool? IsPlacena;
  Klijenti? klijent;
  List<StavkeNarudzbe?>? stavke;

  Narudzbe({
    this.narudzbaId, 
    this.klijentId,
    this.datum, 
    this.ukupniIznos, 
    this.isIsporucena, 
    this.IsPlacena,
    this.klijent,
    this.stavke});

  factory Narudzbe.fromJson(Map<String, dynamic> json) {
    return Narudzbe(
      narudzbaId: json['narudzbaId'] as int,
      klijentId: json['klijentId'] as int,
      datum: DateTime.tryParse(json['datum']),
      ukupniIznos: json['ukupniIznos'] as int,
      isIsporucena: json['isIsporucena'] as bool,
      IsPlacena: json['isPlacena'] as bool,
      //klijent: Klijenti?.fromJson(json['klijent']),
      //stavke: json['stavkeNarudzbe'],
    );
  }

  Map<String, dynamic> toJson() => {
    'narudzbaId':narudzbaId,
    'datum':datum == null ? null : datum!.toIso8601String(),
    'ukupniIznos':ukupniIznos,
    'isIsporucena':isIsporucena,
    'isPlacena':IsPlacena
  };
}