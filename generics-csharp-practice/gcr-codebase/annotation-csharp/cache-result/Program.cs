class Program{
    static void Main(){
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Square(4));
        Console.WriteLine(calc.Square(4)); // cached
    }
}
