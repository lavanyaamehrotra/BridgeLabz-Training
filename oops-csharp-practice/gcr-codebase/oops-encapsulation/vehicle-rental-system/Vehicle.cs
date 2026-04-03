using System;
// Vehicle class to represent a vehicle
public abstract class Vehicle{
    protected double rate;
    
    // Constructor to initialize vehicle details
    protected Vehicle(double rate){
        this.rate = rate;
    }
    // Calculate total rent for given number of days
    public abstract double CalculateRentalCost(int days);
}
