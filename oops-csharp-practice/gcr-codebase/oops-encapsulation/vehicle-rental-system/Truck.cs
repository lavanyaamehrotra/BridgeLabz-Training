public class Truck : Vehicle, IInsurable{
    public Truck(double rate) : base(rate) { }
    // Calculate total rent for given number of days
    public override double CalculateRentalCost(int days){
        return days * rate * 1.5;
    }
    // Calculate insurance amount 
    public double CalculateInsurance(){
        return 5000;
    }
}
