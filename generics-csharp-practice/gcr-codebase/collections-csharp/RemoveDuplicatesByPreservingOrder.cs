using System;
using System.Collections.Generic;
class RemoveDuplicatesByPreservingOrder{
    static void Main(){
        List<int> list = new List<int>();
        List<int> result = new List<int>();
        HashSet<int> seen = new HashSet<int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            list.Add(Convert.ToInt32(Console.ReadLine()));
        }
        foreach (int item in list){
            if (!seen.Contains(item)){
                seen.Add(item);
                result.Add(item);
            }
        }
        Console.WriteLine("List after removing duplicates:");
        foreach (int item in result){
            Console.Write(item + " ");
        }
    }
}
