import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Proizvodi.dart';
import 'package:tattoostudiomobile/model/VrsteProizvoda.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'DetaljiProizvoda.dart';

class SviProizvodi extends StatefulWidget {
  //const SviProizvodi({Key? key}) : super(key: key);
  @override
  _SviProizvodiState createState() => _SviProizvodiState();
}

class _SviProizvodiState extends State<SviProizvodi> {
  VrsteProizvoda? _selectedVrsteProizvoda = null;
  List<DropdownMenuItem> items = [];
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Proizvodi'),
      ),
      body: Column(
        children: [
          Center(child: dropDownWidget()),
          Expanded(child: bodyWidget())
        ],
      ),
    );
  }

  Widget dropDownWidget() {
    return FutureBuilder<List<VrsteProizvoda>>(
        future: GetVrsteProizvoda(_selectedVrsteProizvoda),
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
              return Padding(
                padding: EdgeInsets.fromLTRB(30, 10, 30, 10),
                child: DropdownButton<dynamic>(
                  hint: Text('Odaberite vrstu proizvoda'),
                  isExpanded: true,
                  items: items,
                  onChanged: (newVal) {
                    setState(() {
                      _selectedVrsteProizvoda = newVal; //as VrsteProizvoda;
                      GetProizvodi(_selectedVrsteProizvoda);
                    });
                  },
                  value: _selectedVrsteProizvoda,
                ),
              );
            }
          }
        });
  }

  Future<List<VrsteProizvoda>> GetVrsteProizvoda(VrsteProizvoda? selectedItem) async {
    var vrsteProizvoda = await APIService.Get('TipProizvodum', null);
    var vrsteProizvodaList = vrsteProizvoda!.map((i) => VrsteProizvoda.fromJson(i)).toList();
    items = vrsteProizvodaList.map((item) {
      return DropdownMenuItem<VrsteProizvoda>(
        child: Text(item.naziv),
        value: item,
      );
    }).toList();
    if (selectedItem != null && selectedItem.vrstaId != 0)
      _selectedVrsteProizvoda = vrsteProizvodaList
          .where((element) => element.vrstaId == selectedItem.vrstaId)
          .first;
    return vrsteProizvodaList;
  }

  Widget bodyWidget() {
    return FutureBuilder<List<dynamic>>(
        future: GetProizvodi(_selectedVrsteProizvoda),
        builder: (BuildContext context, AsyncSnapshot<List<dynamic>> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(
              child: Text('Loading...'),
            );
          } else {
            if (snapshot.hasError) {
              return Center(child: Text('${snapshot.error}'));
            } else {
              return ListView(
                children:
                    snapshot.data!.map((e) => ProizvodiWidget(e)).toList(),
              );
            }
          }
        });
  }

  Future<List<dynamic>> GetProizvodi(VrsteProizvoda? selectedItem) async {
    Map<String, String>? queryParams = null;
    if (selectedItem != null && selectedItem.vrstaId != 0)
      queryParams = {'tipProizvodaId': selectedItem.vrstaId.toString()};
    var proizvodi = await APIService.Get('Proizvod', queryParams);
    return proizvodi!.map((i) => Proizvodi.fromJson(i)).toList();
  }

  Widget ProizvodiWidget(proizvod) {
    return Card(
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => DetaljiProizvoda(proizvod: proizvod)));
        },
        child: Padding(
            padding: EdgeInsets.all(15),
            child: Text(proizvod.naziv + ' (' + proizvod.cijena + ' KM)')),
      ),
    );
  }
}
