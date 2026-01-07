using System;
public class Groceries : Product{
  private decimal discountRate;
  public Groceries(int productId, string name, decimal price, decimal discountRate): base(productId, name, price){
    this.discountRate = discountRate;
  }
  // Implement abstract method from Product
  public override decimal CalculateDiscount(){
    return Price * discountRate / 100;
  }
}
