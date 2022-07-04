import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Sidemenu'),
      ),
      drawer: Drawer(
          child: ListView(
        children: [
          DrawerHeader(
            child: Text('TattooStudio'),
            decoration: BoxDecoration(color: Colors.blue),
          ),
          ListTile(
              title: Text('Uredi profil'),
              onTap: () {
                Navigator.of(context).pushNamed('/detaljiKlijenta');
              }),
          ListTile(
              title: Text('Nadolazeći termin'),
              onTap: () {
                Navigator.of(context).pushNamed('/detaljiTermina');
              }),
          ListTile(
              title: Text('Narudžbe'),
              onTap: () {
                Navigator.of(context).pushNamed('/narudzbe');
              }),
          ListTile(
              title: Text('Obavijesti'),
              onTap: () {
                Navigator.of(context).pushNamed('/sveObavijesti');
              }),
          ListTile(
              title: Text('Proizvodi'),
              onTap: () {
                Navigator.of(context).pushNamed('/sviProizvodi');
              }),
          ListTile(
              title: Text('Tattoo & piercing artisti'),
              onTap: () {
                Navigator.of(context).pushNamed('/sviUposlenici');
              }),
          ListTile(
              title: Text('Zakažite termin'),
              onTap: () {
                Navigator.of(context).pushNamed('/zakazivanjeTermina');
              }),
        ],
      )),
    );
  }
}
