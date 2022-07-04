class StavkeNarudzbe{
  int? stavkeNarudzbeId;
  int? proizvodId;
  int? narudzbaId;
  int? kolicina;

  StavkeNarudzbe({this.stavkeNarudzbeId, this.proizvodId, this.narudzbaId, this.kolicina});

  factory StavkeNarudzbe.fromJson(Map<String, dynamic> json) {
    return StavkeNarudzbe(
      stavkeNarudzbeId:int.parse(json["stavkeNarudzbeId"].toString()),
      proizvodId: int.parse(json["proizvodId"].toString()),
      narudzbaId: int.parse(json["narudzbaId"].toString()),
      kolicina: json["kolicina"]
    );
  }

  Map<String, dynamic> toJson() => {
    "stavkeNarudzbeId":stavkeNarudzbeId,
    "proizvodId":proizvodId,
    "narudzbaId":narudzbaId,
    "kolicina":kolicina
  };
}