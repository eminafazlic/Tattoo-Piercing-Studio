import 'package:intl/intl.dart';
import 'package:tattoostudiomobile/model/Klijenti.dart';
import 'package:tattoostudiomobile/model/TipTermina.dart';
import 'package:tattoostudiomobile/model/Uposlenici.dart';

class Termini{
  int? terminId;
  DateTime? datum;
  String? opis;
  double? cijena;
  bool? isOdobren;
  bool? isPlacen;
  bool? isOtkazan;
  String? komentar;
  TipTermina? tipTermina;
  Uposlenici? uposlenik;
  Klijenti? klijent;

  Termini({
    this.terminId,
    this.datum,
    this.opis,
    this.cijena,
    this.isOdobren,
    this.isPlacen,
    this.isOtkazan,
    this.komentar,
    this.tipTermina,
    this.uposlenik,
    this.klijent
});

  factory Termini.fromJson(Map<String, dynamic> json) {
    return Termini(
      terminId: json['terminId'] as int,
      datum: /*DateFormat('MM/dd/yyyy HH:mm:ss')*/DateTime.parse(json['datum'].toString()),
      opis: json['opis'] as String,
      cijena: json['cijena'] as double,
      isOdobren: json['isOdobren'] as bool,
      isPlacen: json['isPlacen'] as bool,
      isOtkazan: json['isOtkazan'] as bool,
      komentar: json['komentar'] as String,
      tipTermina: TipTermina.fromJson(json['tipTermina']),
      uposlenik: Uposlenici.fromJson(json['uposlenik']),
      klijent: Klijenti.fromJson(json['klijent']),
    );
  }

  Map<String, dynamic> toJson() => {
    'terminId':terminId,
    'datum':datum,
    'opis':opis,
    'cijena':cijena,
    'isOdobren':isOdobren,
    'isOtkazan':isOtkazan,
    'komentar':komentar,
    'tipTermina':tipTermina,
    'uposlenik':uposlenik,
    'klijent':klijent
  };

}