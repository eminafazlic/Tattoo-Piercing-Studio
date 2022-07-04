import 'package:tattoostudiomobile/model/Uposlenici.dart';

class Portfolio{
  int? portfolioId;
  String? opis;
  Uposlenici? uposlenik;

  Portfolio({
    this.portfolioId,
    this.opis,
    this.uposlenik
});

  factory Portfolio.fromJson(Map<String, dynamic> json) {
    return Portfolio(
      portfolioId: json['portfolioId'] as int,
      opis: json['opis'] as String,
      uposlenik: Uposlenici.fromJson(json['uposlenik'])
    );
  }

  Map<String, dynamic> toJson() => {
    'portfolioId':portfolioId,
    'opis':opis,
    'uposlenik':uposlenik!.toJson()
  };
}