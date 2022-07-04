class Obavijesti{
  int? obavijestId;
  String? naslov;
  String? sadrzaj;
  DateTime? datum;

  Obavijesti({
    this.obavijestId,
    this.naslov,
    this.sadrzaj,
    this.datum
});

  factory Obavijesti.fromJson(Map<String, dynamic> json){
    return Obavijesti(
        obavijestId: json['obavijestId'] as int,
        naslov: json['naslov'] as String,
        sadrzaj: json['sadrzaj'] as String,
        datum: DateTime.tryParse(json['datum'])
    );
  }

  Map<String, dynamic> toJson() => {
    "obavijestId": obavijestId,
    "naslov": naslov,
    "sadrzaj": sadrzaj,
    "datum": datum == null ? null : datum!.toIso8601String()
  };
}