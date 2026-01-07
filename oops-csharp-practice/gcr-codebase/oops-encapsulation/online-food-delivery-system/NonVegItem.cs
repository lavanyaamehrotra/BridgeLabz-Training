public class NonVegItem : FoodItem{
    public NonVegItem(double price, int quantity) : base(price, quantity) { }
    // Override CalculateTotalPrice method from FoodItem
    public override double CalculateTotalPrice(){
        return (price * quantity) + 50;
    }
}
