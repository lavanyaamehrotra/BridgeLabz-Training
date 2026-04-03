using System;
using System.Collections.Generic;

class TwoSetEqual{
    static void Main(){
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        Console.Write("Enter number of elements in Set 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++){
            set1.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.Write("Enter number of elements in Set 2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++){
            set2.Add(Convert.ToInt32(Console.ReadLine()));
        }
        bool areEqual = set1.SetEquals(set2);
        Console.WriteLine("Are both sets equal?");
        Console.WriteLine(areEqual);
    }
}
