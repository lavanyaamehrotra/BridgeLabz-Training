using System;
using System.Collections.Generic;
class GenerateBinaryNumberUsingQueue{
    static void Main(){
        Queue<string> queue = new Queue<string>();
        List<string> result = new List<string>();
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        queue.Enqueue("1");
        for (int i = 0; i < n; i++){
            string current = queue.Dequeue();
            result.Add(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
        Console.WriteLine("First " + n + " Binary Numbers:");
        foreach (string binary in result){
            Console.Write(binary + " ");
        }
    }
}
