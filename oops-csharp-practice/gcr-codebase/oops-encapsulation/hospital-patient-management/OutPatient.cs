public class OutPatient : Patient{
    public OutPatient(string name) : base(name) { }
    public override double CalculateBill() {
        return 500;
    }
}
