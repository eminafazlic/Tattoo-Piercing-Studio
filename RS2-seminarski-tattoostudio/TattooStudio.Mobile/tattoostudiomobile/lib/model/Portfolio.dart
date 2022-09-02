import 'dart:convert';

import 'package:tattoostudiomobile/model/StavkePortfolija.dart';
import 'package:tattoostudiomobile/model/Uposlenici.dart';

class Portfolio{
  int? portfolioId;
  String? opis;
  //List<int>? slika;
  Uposlenici? uposlenik;
  //StavkePortfolija? stavkePortfolija;

  Portfolio({
    this.portfolioId,
    this.opis,
    //this.slika,
    this.uposlenik,
    //this.stavkePortfolija
});

  factory Portfolio.fromJson(Map<String, dynamic> json) {
    //String stringByte = json["slika"] as String;
    //List<int>bytes=base64.decode(stringByte);
    return Portfolio(
      portfolioId: json['portfolioId'] as int,
      opis: json['opis'] as String,
      //slika: bytes,
      uposlenik: Uposlenici.fromJson(json['uposlenik']),
      //stavkePortfolija: StavkePortfolija.fromJson(json['stavkePortfolia'])
    );
  }

  Map<String, dynamic> toJson() => {
    'portfolioId':portfolioId,
    'opis':opis,
    //'slika':slika,
    'uposlenik':uposlenik!.toJson(),
    //'stavkePortfolia':stavkePortfolija!.toJson()
  };
}