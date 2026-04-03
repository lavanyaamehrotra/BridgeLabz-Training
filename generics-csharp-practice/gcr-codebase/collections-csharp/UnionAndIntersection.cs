using System;
using System.Collections.Generic;
class UnionAndIntersection{
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
        // Union
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);
        // Intersection
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2);
        Console.WriteLine("Union:");
        foreach (int item in unionSet){
            Console.Write(item + " ");
        }
        Console.WriteLine("\nIntersection:");
        foreach (int item in intersectionSet){
            Console.Write(item + " ");
        }
    }
}
