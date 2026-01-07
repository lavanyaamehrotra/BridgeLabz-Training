using System;
public class Program{
  public static void Main(string[] args){
    Product[] products = new Product[5];
    products[0] = new Electronics(101, "Telivision", 80000, 10); 
    products[1] = new Electronics(102, "Smartphone", 20000, 12); 
    products[2] = new Clothing(201, "Skirt", 2000, 20);
    products[3] = new Clothing(202, "Crop-Top", 1000, 10); 
    products[4] = new Groceries(301, "Rice", 500, 5);
    foreach (Product p in products){
      p.DisplayDetails();
      decimal discount = p.CalculateDiscount();
      decimal tax = 0;
      if (p is ITaxable taxable){
        tax = taxable.CalculateTax();
        Console.WriteLine(taxable.GetTaxDetails());
      }
      decimal finalPrice = p.Price + tax - discount;
      Console.WriteLine($"Discount:{discount:C}");
      Console.WriteLine($"Tax:{tax:C}");
      Console.WriteLine($"Final Price:{finalPrice:C}");
    }
    Console.ReadLine();
  }
}
