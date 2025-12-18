using System;
class PrimeNumber{
    static void Main(){
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine()); // Read input
        int count = 0;
        // Loop to check number of divisors
        for (int i = 1; i <= n; i++){
            if (n % i == 0){
                count++;
            }
        }
        // If count of divisors is 2, it's prime
        if (count == 2){
            Console.WriteLine("Prime number");
        }
        else{
            Console.WriteLine("Not a prime number");
        }
    }
}
