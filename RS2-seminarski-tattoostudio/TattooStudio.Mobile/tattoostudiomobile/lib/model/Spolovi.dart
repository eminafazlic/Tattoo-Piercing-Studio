class Spolovi{
  int? spolId;
  String? naziv;

  Spolovi({this.spolId, this.naziv});

  factory Spolovi.fromJson(Map<String, dynamic> json){
    return Spolovi(
      spolId: int.parse(json["spolId"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "spolId":spolId,
    "naziv":naziv,
  };
}