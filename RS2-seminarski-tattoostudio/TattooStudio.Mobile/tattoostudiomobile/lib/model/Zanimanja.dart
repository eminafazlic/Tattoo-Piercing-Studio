class Zanimanja{
  int zanimanjeId;
  String naziv;

  Zanimanja({
    required this.zanimanjeId,
    required this.naziv
});

  factory Zanimanja.fromJson(Map<String, dynamic> json) {
    return Zanimanja(
      zanimanjeId: int.parse(json["zanimanjeId"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "zanimanjeId":zanimanjeId,
    "naziv":naziv,
  };
}