using System;
using System.Diagnostics;

class RecursiveVsIterativeFibonacci{
    //recursive fibonacci
    public static int RecursiveFibonacci(int n){
        if (n <= 1)
            return n;
        return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
    } 
    //iterative fibonacci
    public static int IterativeFibonacci(int n){
        if (n <= 1) return n;
        int a = 0, b = 1, sum = 0;
        for (int i = 2; i <= n; i++){
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
    static void Find(int n){
        Stopwatch sw = new Stopwatch();
        if (n <= 30){     // prevent system freez
            sw.Start();
            RecursiveFibonacci(n);
            sw.Stop();
            Console.Write($"{sw.ElapsedMilliseconds,-15}");
        }
        else{
            Console.Write($"Unfeasible");
        }

        sw.Restart();
        IterativeFibonacci(n);
        sw.Stop();
        Console.WriteLine($"{sw.ElapsedMilliseconds,-15}");
    }
    static void Main(){
        Console.WriteLine("Fibonacci(N)   Recursive(ms)   Iterative(ms)");
        Console.Write("10             ");
        Find(10);
        Console.Write("30             ");
        Find(30);
        Console.Write("50             ");
        Find(50);
        Console.ReadLine();
    }
}
