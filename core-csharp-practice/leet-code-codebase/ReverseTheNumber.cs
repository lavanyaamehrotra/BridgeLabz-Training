using System;

class ReverseTheNumber{
    static void Main(){
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine()); // Read input
        int rn = 0; // variable to store reversed number
        int temp = n; // store original value to avoid losing n
        // Loop for reversing the number
        while (temp > 0){
            int ld = temp % 10;   // get last digit
            rn = rn * 10 + ld;    // build reversed number
            temp = temp / 10;     // remove last digit
        }
        Console.WriteLine("Reversed number: " + rn);
    }
}
