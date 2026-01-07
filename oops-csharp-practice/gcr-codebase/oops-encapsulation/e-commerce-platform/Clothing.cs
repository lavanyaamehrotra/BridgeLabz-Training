using System;
public class Clothing : Product, ITaxable{
  private decimal discountRate;
  public Clothing(int productId, string name, decimal price, decimal discountRate): base(productId, name, price){
    this.discountRate = discountRate;
  }
  public override decimal CalculateDiscount(){
    return Price * discountRate / 100;
  }
  public decimal CalculateTax(){
    return Price * 0.12m; 
  }
  public string GetTaxDetails(){
    return "GST 12% applied for Clothing";
  }
}
