import 'dart:convert';
import 'dart:io';

import 'package:flutter/cupertino.dart';
import 'package:http/io_client.dart';

import 'package:http/http.dart' as http;


class ProductProvider with ChangeNotifier {

  HttpClient client = new HttpClient();
  /*IOClient? http;
  ProductProvider() {
    print("called ProductProvider");
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }*/

  Future<dynamic> get(dynamic searchObject) async {
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
  }
}