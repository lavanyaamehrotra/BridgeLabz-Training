public class VegItem : FoodItem{
    public VegItem(double price, int quantity) : base(price, quantity) { }
    
    // Override CalculateTotalPrice method 
    public override double CalculateTotalPrice(){
        return price * quantity;
    }
}
