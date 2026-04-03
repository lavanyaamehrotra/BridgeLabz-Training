using System;
public class Electronics : Product, ITaxable{
  private decimal discountRate;
  public Electronics(int productId, string name, decimal price, decimal discountRate): base(productId, name, price){
    this.discountRate = discountRate;
  }
  public override decimal CalculateDiscount(){
    return Price * discountRate / 100;
  }
  public decimal CalculateTax(){
    return Price * 0.18m; 
  }
  public string GetTaxDetails(){
    return "GST 18% applied for Electronics";
  }
}
