public class NormalPassenger : Passenger{
    public NormalPassenger(string name, int pnr, int age): base(name, pnr, age){}

    public override double CalculateFare(){
        return 500;//full fare if normal passenger 
    }
}