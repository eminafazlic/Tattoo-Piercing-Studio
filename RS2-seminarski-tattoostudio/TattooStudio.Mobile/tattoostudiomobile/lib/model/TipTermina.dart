class TipTermina{
  int tipTerminaId;
  String naziv;

  TipTermina({
    required this.tipTerminaId,
    required this.naziv,
});

  factory TipTermina.fromJson(Map<String, dynamic> json) {
    return TipTermina(
        tipTerminaId: int.parse(json["tipTerminaId"].toString()),
        naziv: json["naziv"]
    );
  }

  Map<String, dynamic> toJson() => {
    "tipTerminaId":tipTerminaId,
    "naziv":naziv,
  };
}