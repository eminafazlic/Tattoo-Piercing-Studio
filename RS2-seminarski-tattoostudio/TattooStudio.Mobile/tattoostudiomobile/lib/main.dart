
/*import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:tattoostudiomobile/ProductListScreen.dart';
import 'package:tattoostudiomobile/providers/product_provider.dart';

void main() => runApp(MultiProvider(
  providers: [
    ChangeNotifierProvider(create: (_) => ProductProvider()),
  ],
  child: MaterialApp(
    debugShowCheckedModeBanner: true,
    home: HomePage(),
    onGenerateRoute: (settings) {
      if(settings.name==ProductListScreen.routeName)
      {
        return MaterialPageRoute(builder: ((context)=>ProductListScreen()));
      }
    }
  )
));

class HomePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Flutter Row Example"),
      ),
      body: SingleChildScrollView(
          child: Column(
        children: [
          Container(
            height: 400,
            decoration: BoxDecoration(
                image: DecorationImage(
                    image: AssetImage("assets/images/background.jpg"),
                    fit: BoxFit.fill)),
            child: Stack(children: [
              Positioned(
                  left: 120,
                  top: 0,
                  width: 80,
                  height: 120,
                  child: Container(
                      decoration: BoxDecoration(
                          image: DecorationImage(
                    image: AssetImage("assets/images/light-1.png"),
                  )))),
              Positioned(
                  right: 40,
                  top: 0,
                  width: 80,
                  height: 120,
                  child: Container(
                      decoration: BoxDecoration(
                          image: DecorationImage(
                    image: AssetImage("assets/images/clock.png"),
                  )))),
              Container(
                child: Center(
                  child: Text("Login", style: TextStyle(color: Colors.white, fontSize: 40, fontWeight: FontWeight.bold),)
                  ),
              )
            ]),
          ),
          Padding(
            padding: EdgeInsets.all(40),
            child: Container(
              decoration: BoxDecoration(
                color: Colors.white,
                borderRadius: BorderRadius.circular(10)
              ),
              child: Column(
              children: [
                Container(
                  padding: EdgeInsets.all(8),
                  decoration: BoxDecoration(
                    border: Border(bottom: BorderSide(color: Colors.grey))
                  ),
                  child: TextField(
                          decoration: InputDecoration(border: InputBorder.none, hintText: "Email or phone", hintStyle: TextStyle(color: Colors.grey[400])),
                  ),
                ),
                Container(
                  padding: EdgeInsets.all(8),
                  child: TextField(
                          decoration: InputDecoration(border: InputBorder.none, hintText: "Pasword", hintStyle: TextStyle(color: Colors.grey[400])),
                  ),
                ),

                
              ]),
            ),
          ),
          SizedBox(height: 2,),
          Container(
                  height: 50,
                  margin: EdgeInsets.fromLTRB(40, 0, 40, 0),
                  decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    gradient: LinearGradient(
                      colors: [Color.fromRGBO(143, 148, 251, 1), Color.fromRGBO(143, 148, 251, .6)]
                    ),
                    
                  ),
                  child: InkWell(
                    onTap: () {
                      Navigator.pushNamed(context, ProductListScreen.routeName);
                    },
                    child: Center(child: Text("Login")),
                  ),
                ),
          SizedBox(height: 40,),
          Text("Forgot password?"),
          SizedBox(height: 40,),
        ],
      ),
      ),
    );
  }
}*/

import 'dart:io';

import 'package:flutter/material.dart';
import 'package:tattoostudiomobile/screens/DetaljiKlijenta.dart';
import 'package:tattoostudiomobile/screens/DetaljiObavijesti.dart';
import 'package:tattoostudiomobile/screens/DetaljiProizvoda.dart';
import 'package:tattoostudiomobile/screens/DetaljiTermina.dart';
import 'package:tattoostudiomobile/screens/Home.dart';
import 'package:tattoostudiomobile/screens/Loading.dart';
import 'package:tattoostudiomobile/screens/Login.dart';
import 'package:tattoostudiomobile/screens/Pocetna.dart';
import 'package:tattoostudiomobile/screens/PortfolioDetalji.dart';
import 'package:tattoostudiomobile/screens/Registracija.dart';
import 'package:tattoostudiomobile/screens/SveObavijesti.dart';
import 'package:tattoostudiomobile/screens/SviProizvodi.dart';
import 'package:tattoostudiomobile/screens/SviUposlenici.dart';
import 'package:tattoostudiomobile/screens/ZakazivanjeTermina.dart';
import 'package:tattoostudiomobile/screens/Narudzba.dart';

import 'model/Narudzbe.dart';

class IgnoreCertificateErrorOverrides extends HttpOverrides{
  @override
  HttpClient createHttpClient(SecurityContext? context){
    return super.createHttpClient(context)
      ..badCertificateCallback = ((X509Certificate cert, String host, int port) {
        return true;
      });
  }
}

void main() {
  HttpOverrides.global=new IgnoreCertificateErrorOverrides();
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home:Pocetna(),
      routes: {
        '/detaljiKlijenta':(context)=>DetaljiKlijenta(),
        '/detaljiObavijesti':(context)=>DetaljiObavijesti(),
        'detaljiProizvoda':(context)=>DetaljiProizvoda(),
        '/detaljiTermina':(context)=>DetaljiTermina(),
        '/home':(context)=>Home(),
        '/loading':(context)=>Loading(),
        '/login':(context)=>Login(),
        '/narudzbe':(context)=>Narudzba(),
        '/portfolioDetalji':(context)=>PortfolioDetalji(),
        '/registracija':(context)=>Registracija(),
        '/sveObavijesti':(context)=>SveObavijesti(),
        '/sviProizvodi':(context)=>SviProizvodi(),
        '/sviUposlenici':(context)=>SviUposlenici(),
        '/zakazivanjeTermina':(context)=>ZakazivanjeTermina(),
      }
    );
  }
}