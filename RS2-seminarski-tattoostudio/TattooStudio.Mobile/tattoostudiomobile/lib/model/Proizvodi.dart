import 'dart:convert';

class Proizvodi
{
  final proizvodId;
  final String? naziv;
  final String? cijena;
  final List<int>? slika;
  final String? opis;

  Proizvodi({
    this.proizvodId,
    this.naziv,
    this.cijena,
    this.slika,
    this.opis,
});

  factory Proizvodi.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slika"] as String;
    List<int>bytes=base64.decode(stringByte);
    return Proizvodi(
      proizvodId:["proizvodId"],
      naziv:json["naziv"],
      cijena:json["cijena"].toString(),
      slika: bytes,
      opis:json["opis"],
    );
  }

  Map<String, dynamic> toJson() => {
    "proizvodId":proizvodId,
    "naziv":naziv,
    "cijena":cijena,
    "slika":slika,
    "opis":opis,
  };
}