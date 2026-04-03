using System;
public class Bike : Vehicle{
    public Bike(double rate) : base(rate) { }
    // Calculates total rent for given number of days
    public override double CalculateRentalCost(int days){
        return days * rate;
    }
}
