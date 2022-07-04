import 'dart:convert';

class StavkePortfolija{
  int? stavkePortfolijaId;
  List<int>? slika;
  DateTime? datum;
  String? opis;

  StavkePortfolija({
    this.stavkePortfolijaId,
    this.slika,
    this.datum,
    this.opis
});

  factory StavkePortfolija.fromJson(Map<String, dynamic> json){
    String stringByte = json['slika'] as String;
    List<int>bytes=base64.decode(stringByte);
    return StavkePortfolija(
      stavkePortfolijaId: json['stavkePortfoliumId'] as int,
      datum: DateTime.tryParse(json['datum']),
      opis: json['opis'],
      slika: bytes
    );
  }

  Map<String, dynamic> toJson() => {
    'stavkePortfoliumId':stavkePortfolijaId,
    'slika':slika,
    'opis':opis,
    'datum':datum == null ? null : datum!.toIso8601String(),
  };
}