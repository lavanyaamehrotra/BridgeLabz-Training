using System;
class Product{
    public static double Discount = 2.0;

    // Static method to update discount
    public static void DiscountUpdate(double newDiscount){
      Discount = newDiscount;
      Console.WriteLine($"Discount updated to {Discount}%\n");
    }
    // Readonly variable 
    public readonly int ProductID;
    // Instance variables
    public string ProductName;
    public double Price;
    public int Quantity;
    // Constructor
    public Product(int productID, string productName, double price, int quantity){
      this.ProductID = productID;
      this.ProductName = productName;
      this.Price = price;
      this.Quantity = quantity;
    }
    // Method to display product details
    public void DisplayDetails(){
    double discountedprice = Price - (Price * Discount / 100);
    Console.WriteLine("Product Details:");
    Console.WriteLine($"Product id: {ProductID}");
    Console.WriteLine($"Product Name: {ProductName}");
    Console.WriteLine($"Price:{Price}");
    Console.WriteLine($"Quantity:{Quantity}");
    Console.WriteLine($"Discount:{Discount}%");
    Console.WriteLine($"Final Price:{discountedprice}\n");
  }
}
class ShoppingCart{
  static void Main(){
    // Update static discount
    Product.DiscountUpdate(20);
    // Create product objects
    object p1 = new Product(123, "Laptop", 5500, 1);
    object p2 = new Product(321, "Headphones", 250, 2);
    // Using 'is' operator before processing
    if (p1 is Product){
      ((Product)p1).DisplayDetails();
    }
    if (p2 is Product){
      ((Product)p2).DisplayDetails();
    }
    Console.ReadLine();
  }
}
