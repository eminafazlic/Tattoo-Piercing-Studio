//import 'dart:html';

class VrsteProizvoda{
  int vrstaId;
  String naziv;

  VrsteProizvoda({
    required this.vrstaId,
    required this.naziv,
});

  factory VrsteProizvoda.fromJson(Map<String, dynamic> json) {
    return VrsteProizvoda(
      vrstaId: int.parse(json["tipProizvodaId"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "tipProizvodaId":vrstaId,
    "naziv":naziv
  };

}