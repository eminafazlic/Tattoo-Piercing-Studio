
import 'package:flutter/material.dart';
import 'package:provider/src/provider.dart';
import 'package:tattoostudiomobile/providers/product_provider.dart';

class ProductListScreen  extends StatefulWidget {
  static const String routeName = "/product";

  const ProductListScreen({ Key? key }) : super(key: key);

  @override
  State<ProductListScreen> createState() => _ProductListScreenState();
}

class _ProductListScreenState extends State<ProductListScreen>{

  ProductProvider? _productProvider = null;
  dynamic data = {};

  @override
  void initState() {
    super.initState();
    _productProvider=context.read<ProductProvider>();
    print("called InitState");
    loadData();
  }

  Future loadData() async {
    var tmpData = await _productProvider?.get(null);
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    print("called build");
    return Scaffold(
      body: Center(child: Text(data!.length.toString())),
    );
  }
}