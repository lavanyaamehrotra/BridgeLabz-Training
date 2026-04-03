using System;
public class Car : Vehicle, IInsurable{
    public Car(double rate) : base(rate) { }
    // Calculate total rent for given number of days
    public override double CalculateRentalCost(int days){
        return days * rate;
    }
    // Calculate insurance amount
    public double CalculateInsurance(){
        return 3000;
    }
}
