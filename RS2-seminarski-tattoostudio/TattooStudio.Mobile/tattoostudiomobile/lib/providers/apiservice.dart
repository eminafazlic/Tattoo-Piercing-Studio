// ignore_for_file: non_constant_identifier_names, avoid_print

import 'dart:convert';
import 'dart:io';
import 'package:flutter/cupertino.dart';
import 'package:http/http.dart' as http;

class APIService with ChangeNotifier {

  HttpClient client = HttpClient();

  static int? klijentId;
  static String? korisnickoIme;
  static String? lozinka;
  static String? token;
  String route;
  static int? aktivnaNarudzba;

  APIService({required this.route});

  static void SetParameters(int KlijentId, String KorisnickoIme, String Lozinka)
  {
    klijentId=KlijentId;
    korisnickoIme=KorisnickoIme;
    lozinka=Lozinka;
  }

  //static const String _baseRoute = "http://10.0.2.2:52830/api/";
  static const String _baseRoute = "http://10.0.2.2:80/api/";

  static Future<String?> prijava(String KorisnickoIme, String Lozinka) async{

    
    String baseUrl = _baseRoute + "Klijent/login";
    final response = await http.post(Uri.parse(baseUrl),
       headers: <String, String>{
         'Content-Type': 'application/json; charset=UTF-8',
       },
      body: jsonEncode(<String, String>{
         'username': KorisnickoIme,
         'password': Lozinka,
       }),
    );
     if (response.statusCode == 200)
     {
     Map<String, dynamic> map = jsonDecode(response.body);
     klijentId = map['id'];
     token = map['token'];

     String baseUrl2 = _baseRoute + "Narudzba/AktivnaNarudzba/${klijentId}";
     var narudzba = await http.get(Uri.parse(baseUrl2),
     headers:
      {'Authorization' : 'Bearer $token'});
      aktivnaNarudzba = json.decode(narudzba.body) as int;

     return response.body;
     }

  return null;
}

  static Future<List<dynamic>?> Get(String route, dynamic object) async{
    String queryString=Uri(queryParameters: object).query;
    String baseUrl=_baseRoute+route;
    if(object!=null){
      baseUrl=baseUrl+'?'+queryString;
    }
    final response=await http.get(
      Uri.parse(baseUrl),
      headers://{HttpHeaders.authorizationHeader:'Bearer ${token}'}
      {'Authorization' : 'Bearer $token'}
    );
    if(response.statusCode==200)
      {
        return json.decode(response.body) as List;
      }
    return null;
  }

  static Future<dynamic> GetById(String route, dynamic id, dynamic search) async
  {
    String baseUrl = _baseRoute + route;
    if(search!=null){
      baseUrl=baseUrl+'?'+search.toString();
    }
    else
      baseUrl=_baseRoute+route+"/"+id.toString();
    final response=await http.get(
      Uri.parse(baseUrl),
      headers:{'Authorization':'Bearer $token'}
    );
    if(response.statusCode==200)
    {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> Post(String route, String body) async
  {
    String baseUrl=_baseRoute+route;
    final response=await http.post(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        'Authorization':'Bearer $token'
      },
      body: body,
    );
    if(response.statusCode==200)
      {
        return json.decode(response.body);
      }
    return null;
  }

  static Future<dynamic> Put(String route, int id, String body) async {
    String baseUrl = _baseRoute + route + "/" + id.toString();
    final response = await http.put(
      Uri.parse(baseUrl),
      headers: {
        HttpHeaders.contentTypeHeader: 'application/json; charset=UTF-8',
        // HttpHeaders.authorizationHeader: basicAuth
        'Authorization':'Bearer $token'
      },
      body: body,
    );
    if (response.statusCode == 200) {
      return json.decode(response.body);
    }
      return null;
  }

  static Future<bool?> Delete(String route, dynamic id) async {
    String baseUrl = _baseRoute + route + "/" + id.toString();
    final response = await http.delete(
      Uri.parse(baseUrl),
      headers: {'Authorization':'Bearer $token'},
    );

    if (response.statusCode == 200) {
      return json.decode(response.body);
    }
      return null;
  }





  /*Future<dynamic> get(dynamic searchObject) async {
    print("called ProductProvider.GET METHOD");
    var url = Uri.parse("http://10.0.2.2:52830/api/Proizvod");

    var headers = {
      "Content-Type" : "application/json",
    };

    var response = await http.get(url);//, headers: headers);
    if(response.statusCode<400) {
      var data = jsonDecode(response.body);
      return data;
    }
    else {
      throw Exception("User not allowed");
    }
  }*/
}