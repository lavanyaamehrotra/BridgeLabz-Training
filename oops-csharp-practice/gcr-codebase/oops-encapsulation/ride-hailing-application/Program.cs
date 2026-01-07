using System;
class Program{
    public static void Main(string[] args){
        Vehicle v1 = new Car(10);
        Vehicle v2 = new Bike(20);
        Vehicle v3 = new Auto(30);
        System.Console.WriteLine(v1.CalculateFare(10));
        System.Console.WriteLine(v2.CalculateFare(10));
        System.Console.WriteLine(v3.CalculateFare(10));
    }
}
