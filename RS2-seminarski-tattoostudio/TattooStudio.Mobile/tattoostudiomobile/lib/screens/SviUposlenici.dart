import 'dart:async';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Uposlenici.dart';
import 'package:tattoostudiomobile/model/Zanimanja.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'PortfolioDetalji.dart';

class SviUposlenici extends StatefulWidget {
  @override
  _SviUposleniciState createState() => _SviUposleniciState();
}

class _SviUposleniciState extends State<SviUposlenici> {
  Zanimanja? _selectedZanimanje = null;
  List<DropdownMenuItem> items = [];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Tattoo & piercing artisti'),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        children: [
          Center(child: dropDownWidget()),
          Expanded(child: bodyWidget()),
        ],
      ),
    );
  }

  Widget dropDownWidget() {
    return FutureBuilder<List<Zanimanja>>(
        future: GetZanimanja(_selectedZanimanje),
        builder:
            (BuildContext context, AsyncSnapshot<List<Zanimanja>> snapshot) {
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
              return Padding(
                padding: EdgeInsets.fromLTRB(30, 10, 30, 10),
                child: DropdownButton<dynamic>(
                  hint: Text('Filtrirajte po zanimanju'),
                  isExpanded: true,
                  items: items,
                  onChanged: (newVal) {
                    setState(() {
                      _selectedZanimanje = newVal as Zanimanja;
                      GetUposlenici(_selectedZanimanje);
                    });
                  },
                  value: _selectedZanimanje,
                ),
              );
            }
          }
        });
  }

  Future<List<Zanimanja>> GetZanimanja(Zanimanja? selectedItem) async {
    var zanimanja = await APIService.Get('Zanimanje', null);
    var zanimanjaList = zanimanja!.map((i) => Zanimanja.fromJson(i)).toList();

    items = zanimanjaList.map((item) {
      return DropdownMenuItem<Zanimanja>(
        child: Text(item.naziv),
        value: item,
      );
    }).toList();

    if (selectedItem != null && selectedItem.zanimanjeId != 0)
      _selectedZanimanje = zanimanjaList
          .where((element) => element.zanimanjeId == selectedItem.zanimanjeId)
          .first;
    return zanimanjaList;
  }

  Widget bodyWidget() {
    return FutureBuilder<List<dynamic>>(
        future: GetUposlenici(_selectedZanimanje),
        builder: (BuildContext context, AsyncSnapshot<List<dynamic>> snapshot) {
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
                    snapshot.data!.map((e) => UposleniciWidget(e)).toList(),
              );
            }
          }
        });
  }

  Future<List<dynamic>> GetUposlenici(Zanimanja? selectedItem) async {
    // ignore: avoid_init_to_null
    Map<String, String>? queryParams = null;
    if (selectedItem != null && selectedItem.zanimanjeId != 0)
      queryParams = {'zanimanjeId': selectedItem.zanimanjeId.toString()};

    var uposlenici = await APIService.Get('Uposlenik', queryParams);
    return uposlenici!.map((i) => Uposlenici.fromJson(i)).toList();
  }

  Widget UposleniciWidget(uposlenik) {
    return Card(
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => PortfolioDetalji(
                       uposlenik: uposlenik,
                      )));
        },
        child: Padding(
          padding: EdgeInsets.all(20),
          child: Row(
            children: [
              Expanded(
                child: Text(
                  uposlenik.ime + ' ' + uposlenik.prezime,
                  style: TextStyle(color: Colors.black),
                ),
              )
            ],
          ),
        ),
      ),
    );
  }
}
