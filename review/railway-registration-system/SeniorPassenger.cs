public class SeniorPassenger : Passenger{
    public SeniorPassenger(string name, int pnr, int age): base(name, pnr, age){}
    public override double CalculateFare(){
            double baseFare = 500;
            return baseFare * 0.5; //discount
        }
    }