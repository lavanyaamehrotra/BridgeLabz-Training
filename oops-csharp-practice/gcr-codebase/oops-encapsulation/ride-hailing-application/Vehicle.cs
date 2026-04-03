public abstract class Vehicle{
    protected double rate;
    protected Vehicle(double rate){
        this.rate = rate;
    }
    // Abstract method to calculate fare
    public abstract double CalculateFare(double distance);
}
