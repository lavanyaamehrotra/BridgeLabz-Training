using System;
using System.Collections.Generic;
class SetToSortedList{
    static void Main(){
        HashSet<int> set = new HashSet<int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            set.Add(Convert.ToInt32(Console.ReadLine()));
        }
        // Convert HashSet to List
        List<int> sortedList = new List<int>(set);
        // Sort the list
        sortedList.Sort();
        Console.WriteLine("Sorted List:");
        foreach (int item in sortedList){
            Console.Write(item + " ");
        }
    }
}
