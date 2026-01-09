using System;

class QueueUsingStack{
    static int MAX = 10;
    static int[] stack1 = new int[MAX]; // enqueue 
    static int[] stack2 = new int[MAX]; // dequeue
    static int top1 = -1;
    static int top2 = -1;
    // Push into stack
    static void Push(int[] stack, ref int top, int value){
        stack[++top] = value;
    }
    // Pop from stack
    static int Pop(int[] stack, ref int top){
        return stack[top--];
    }
    // Enqueue operation
    static void Enqueue(int value){
        Push(stack1, ref top1, value);
        Console.WriteLine("Enqueued: " + value);
    }
    // Dequeue operation
    static void Dequeue(){
        if (top1 == -1 && top2 == -1){
          Console.WriteLine("Queue is empty.");
          return;
        }
        if (top2 == -1){
          while (top1 != -1){
            Push(stack2, ref top2, Pop(stack1, ref top1));
          }
        }
        Console.WriteLine("Dequeued: " + Pop(stack2, ref top2));
    }
    // Display queue
    static void Display(){
        if (top1 == -1 && top2 == -1){
            Console.WriteLine("Queue is empty.");
            return;
        }
        Console.Write("Queue Elements: ");
        for (int i = top2; i >= 0; i--){
            Console.Write(stack2[i] + " ");
        }
        for (int i = 0; i <= top1; i++){
            Console.Write(stack1[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main(){
      int choice;
      do{
            Console.WriteLine("\n--- Queue Using Stacks ---");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
              case 1:
                Console.Write("Enter value: ");
                Enqueue(int.Parse(Console.ReadLine()));
                break;
              case 2:
                Dequeue();
                break;
              case 3:
                Display();
                break;
            }

        } while (choice != 4);
    }
}
