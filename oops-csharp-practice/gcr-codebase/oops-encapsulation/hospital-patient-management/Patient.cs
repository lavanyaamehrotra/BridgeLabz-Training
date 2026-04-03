public abstract class Patient{
    protected string name;
    protected Patient(string name){
        this.name = name;
    }
    // Abstract method to calculate total bill
    public abstract double CalculateBill();
}
