
import 'dart:convert';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/model/Portfolio.dart';
import 'package:tattoostudiomobile/model/StavkePortfolija.dart';
import 'package:tattoostudiomobile/model/Uposlenici.dart';
import 'package:tattoostudiomobile/providers/apiservice.dart';
import 'package:tattoostudiomobile/screens/DetaljiStavkePortfolija.dart';

import 'DetaljiProizvoda.dart';

class PortfolioDetalji extends StatelessWidget {
  final Uposlenici? uposlenik;
  PortfolioDetalji({ Key? key, this.uposlenik }) : super(key: key);

  List<dynamic>? _stavkePortfolija = [];
  Portfolio? _portfolio;
  Future<List<dynamic>?> getStavkePortfolija() async {
    var portfolio = await APIService.GetById("Portfolio", uposlenik!.uposlenikId, "UposlenikId=${uposlenik!.uposlenikId}");
    portfolio!.map((i)=>Portfolio.fromJson(i));
    if(portfolio.isNotEmpty) {
      _portfolio = new Portfolio.fromJson(portfolio[0]);
      var stavke = await APIService.GetById("StavkePortfolium", _portfolio!.portfolioId, "PortfolioId=${_portfolio!.portfolioId}");
      if(stavke.isNotEmpty) {
        stavke!.map((i)=>StavkePortfolija.fromJson(i)).toList();
        _stavkePortfolija = stavke;
      } 
    }
    return _stavkePortfolija;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('Portfolio uposlenika'),
          backgroundColor: Colors.blue,
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<dynamic>(
        future: getStavkePortfolija(),
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
            } else if (_portfolio==null) {
                return Center(child: Text("Uposlenik nema potrfolio"));
            } 
            else {
              return SingleChildScrollView(
                  child: Padding(
                  padding: const EdgeInsets.all(30),
                  child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: [
                    Text(
                    '${_portfolio!.uposlenik!.ime} ${_portfolio!.uposlenik!.prezime}',
                      style: const TextStyle(
                        fontSize: 18, fontWeight: FontWeight.w500, color: Colors.blue),
                    textAlign: TextAlign.center,),
                  const SizedBox(
                    height: 26,
                  ),
                  Text(
                    'Opis portfolija: ${_portfolio!.opis}',
                      style: const TextStyle(
                        fontSize: 16, fontWeight: FontWeight.w400, color: Colors.blue),
                    textAlign: TextAlign.center,),
                  const SizedBox(
                    height: 26,
                  ),
                  ListView(
                    shrinkWrap:true,
                  children: 
                  _stavkePortfolija!.map((e) => new Card(
                    child: TextButton(
                    onPressed: () {
                    Navigator.push(
                    context,
                    MaterialPageRoute(
                    builder: (context) => DetaljiStavkePortfolija(stavka: new StavkePortfolija.fromJson(e))));},
                      child: Padding(
                      padding: EdgeInsets.all(15),
                      child: Text("Stavka portfolija ${e['stavkaPortfoliaId']} (klikni za više detalja)")))))
                      .toList()
                  )])));}}});}}