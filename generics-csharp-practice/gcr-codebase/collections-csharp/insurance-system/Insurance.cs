using System;
using System.Collections.Generic;
class Insurance{
    public static void Main(){
        HashSet<int> policyNumbers = new HashSet<int>();
        Console.Write("How many policies? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++){
            Console.Write("Enter policy number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter coverage type: ");
            string coverage = Console.ReadLine();
            if (policyNumbers.Contains(number)){
                Console.WriteLine("Duplicate policy not allowed");
            }
            else{
                policyNumbers.Add(number);
                Console.WriteLine("Policy added");
            }
        }
        Console.WriteLine("\nAll unique policy numbers:");
        foreach (int num in policyNumbers){
            Console.WriteLine(num);
        }
    }
}
