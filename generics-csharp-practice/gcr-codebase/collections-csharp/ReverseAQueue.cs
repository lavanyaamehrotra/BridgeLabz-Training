using System;
using System.Collections.Generic;
class ReverseAQueue{
    static void Reverse(Queue<int> queue){
        if (queue.Count == 0){
            return;
        }
        int front = queue.Dequeue();
        Reverse(queue);
        queue.Enqueue(front);
    }
    static void Main(){
        Queue<int> queue = new Queue<int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
        }
        Reverse(queue);
        Console.WriteLine("Reversed Queue:");
        foreach (int item in queue){
            Console.Write(item + " ");
        }
    }
}
