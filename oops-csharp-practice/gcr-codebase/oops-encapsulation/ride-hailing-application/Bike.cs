public class Bike : Vehicle{
    public Bike(double rate) : base(rate) { }
    // Calculate total fare for given distance
    public override double CalculateFare(double distance){
        return distance * rate * 0.8;
    }
}
