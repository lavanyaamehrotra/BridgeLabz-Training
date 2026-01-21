using System;
using System.Collections.Generic;
class FindNthElementFromEnd{
    static void Main(){
        LinkedList<string> list = new LinkedList<string>();
        Console.Write("Enter number of elements:");
        int count = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < count; i++){
            list.AddLast(Console.ReadLine());
        }
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;
        // Move first pointer n steps ahead
        for (int i = 0; i < n; i++){
            if (first == null){
                Console.WriteLine("N is greater than the number of elements.");
                return;
            }
            first = first.Next;
        }
        // Move both pointers until first reaches end
        while (first != null){
            first = first.Next;
            second = second.Next;
        }
        Console.WriteLine("Nth element from the end:");
        Console.WriteLine(second.Value);
    }
}
