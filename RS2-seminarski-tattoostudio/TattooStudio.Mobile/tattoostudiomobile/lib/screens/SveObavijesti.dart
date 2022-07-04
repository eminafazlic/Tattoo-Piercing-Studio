import 'dart:async';
//import 'dart:js_util';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Obavijesti.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'DetaljiObavijesti.dart';

class SveObavijesti extends StatefulWidget {
  @override
  _SveObavijestiState createState() => _SveObavijestiState();
}

class _SveObavijestiState extends State<SveObavijesti> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('Obavijesti'),
          backgroundColor: Colors.blue,
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<dynamic>(
        future: GetObavijesti(),
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(
              child: Text('Loading...'),
            );
          } else {
            if (snapshot.hasError) {
              return Center(
                child: Text('${snapshot.error}'),
              );
            } else {
              return ListView(
                children:
                snapshot.data.map<Widget>((e)=>ObavijestiWidget(e)).toList(),
          );
            }
          }
        });
  }

  Future<dynamic> GetObavijesti() async {
    var obavijesti = await APIService.Get('Obavijest', null);
    return obavijesti!.map((i) => Obavijesti.fromJson(i)).toList();
  }

  Widget ObavijestiWidget(obavijest) {
    return Card(
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) =>
                      DetaljiObavijesti(obavijest: obavijest)));
        },
        child:
            Padding(padding: EdgeInsets.all(20), child: Text(obavijest.naslov)),
      ),
    );
  }
}
