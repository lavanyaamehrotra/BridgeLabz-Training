using System;
public abstract class Product{
  private int productId;
  private string name;
  private decimal price;
  // Properties 
  public int ProductId{
    get { 
      return productId; 
    }
    protected set { 
      productId = value; 
    }
  }
  public string Name{
    get { 
      return name; 
    }
    protected set { 
      name = value;
    }
  }
  public decimal Price{
    get { 
      return price; 
    }
    protected set { 
      price = value; 
    }
  }
  // Constructor
  protected Product(int productId, string name, decimal price){
    ProductId = productId;
    Name = name;
    Price = price;
  }
  public abstract decimal CalculateDiscount();
  // Method to display basic product details
  public virtual void DisplayDetails(){
    Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}");
  }
}
