public class InPatient : Patient{
    private int days;
    // Parameterized constructor
    public InPatient(string name, int days) : base(name){
        this.days = days;
    }
    // Method to calculate total bill amount
    public override double CalculateBill(){
        return days * 3000;
    }
}
