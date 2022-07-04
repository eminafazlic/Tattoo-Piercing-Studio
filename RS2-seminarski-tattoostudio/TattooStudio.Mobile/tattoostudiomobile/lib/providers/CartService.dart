import 'package:tattoostudiomobile/model/CartModel.dart';
import 'package:tattoostudiomobile/model/Proizvodi.dart';

//ovako je anisa napravila dodavanje u korpu

class CartService{
  static Map<String, CartModel> products= new Map<String, CartModel>();

  static void RemoveProduct(String id){
    products.remove(id);
  }

  static void AddProduct(Proizvodi product, int quantity){
    CartModel cm=new CartModel();
    cm.proizvod=product;
    cm.kolicina=quantity;
    Map<String, CartModel> map= {'${product.proizvodId}': cm};
    if(!products.containsKey('${product.proizvodId}')) {
      products.addAll(map);
      print(map['${product.proizvodId}']!.proizvod!.naziv! + '  '+ map['${product.proizvodId}']!.kolicina.toString());
    }
    else{
      var cm=products['${product.proizvodId}'];
      if(cm!.kolicina!=null)
        {
          cm.kolicina=(cm.kolicina!+1);
        }
      products.update('${product.proizvodId}', (value) => cm);
      print(cm.kolicina);
    }
  }
}