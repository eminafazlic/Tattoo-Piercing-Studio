class Narudzbe{
  int? narudzbaId;
  DateTime? datum;
  double? ukupniIznos;
  bool? isIsporucena;

  Narudzbe({this.narudzbaId, this.datum, this.ukupniIznos, this.isIsporucena});

  factory Narudzbe.fromJson(Map<String, dynamic> json) {
    return Narudzbe(
      narudzbaId: json['narudzbaId'] as int,
      datum: DateTime.tryParse(json['datum']),
      ukupniIznos: json['ukupniIznos'] as double,
      isIsporucena: json['isIsporucena'] as bool
    );
  }

  Map<String, dynamic> toJson() => {
    'narudzbaId':narudzbaId,
    'datum':datum == null ? null : datum!.toIso8601String(),
    'ukupniIznos':ukupniIznos,
    'isIsporucena':isIsporucena
  };
}