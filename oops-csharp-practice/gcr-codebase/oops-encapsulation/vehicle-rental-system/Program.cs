class Program{
    public static void Main(string [] args){
        Vehicle v1 = new Car(3000);
        Vehicle v2 = new Bike(700);
        Vehicle v3 = new Truck(6000);
        System.Console.WriteLine(v1.CalculateRentalCost(3));
        System.Console.WriteLine(v2.CalculateRentalCost(3));
        System.Console.WriteLine(v3.CalculateRentalCost(3));
    }
}
