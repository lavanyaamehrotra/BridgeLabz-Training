public abstract class FoodItem{
    protected double price;
    protected int quantity;
    protected FoodItem(double price, int quantity){
        this.price = price;
        this.quantity = quantity;
    }
    // Abstract method to calculate total price
    public abstract double CalculateTotalPrice();
}
