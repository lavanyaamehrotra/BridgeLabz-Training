using System;
class Product{
  // Instance Variables
  public string productName;
  public double price;
  // Class Variable 
  public static int totalProducts = 0;
  // Constructor
  public Product(string name, double price){
    this.productName = name;
    this.price = price;
    totalProducts++;
  }
  // Instance Method
  public void DisplayProduct(){
    Console.WriteLine("Product Name: " + productName);
    Console.WriteLine("Price: " + price);
  }
  // Class Method
  public static void DisplayTotal(){
    Console.WriteLine("Total Products Created: " + totalProducts);
  }
}
//class to run
class Program{
  static void Main(string[] args){
    Product p1 = new Product("Laptop", 55000);
    Product p2 = new Product("Smartphone", 30000);
    p1.DisplayProduct();
    Console.WriteLine();
    p2.DisplayProduct();
    Console.WriteLine();
    Product.DisplayTotal();
  }
}
