using System;
using System.Collections.Generic;
public class ProductCatalog<TProduct>{
    private List<TProduct> products = new List<TProduct>();
    public void AddProduct(TProduct product){
        products.Add(product);
    }
    //remove product
    public void RemoveProduct(TProduct product){
        products.Remove(product);
    }
    //display catolog
    public void DisplayCatalog(){
        foreach (var product in products){
            dynamic p = product;
            p.Display();
        }
    }
    public List<TProduct> GetAllProducts(){
        return products;
    }
}
