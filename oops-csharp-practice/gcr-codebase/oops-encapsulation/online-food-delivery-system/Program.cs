using System;
class Program{
    public static void Main(string[] args){
        FoodItem f1 = new VegItem(400, 2);
        FoodItem f2 = new NonVegItem(500, 1);
        System.Console.WriteLine(f1.CalculateTotalPrice());
        System.Console.WriteLine(f2.CalculateTotalPrice());
    }
}
