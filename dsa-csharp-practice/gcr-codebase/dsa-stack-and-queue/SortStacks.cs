using System;
class SortStacks{
  // function to sort the stack
  public static void SortStack(Stack<int> stack){
    if (stack.Count == 0){
        return;
    }
    // Pop top element
    int top = stack.Pop();
    // Sort remaining stack
    SortStack(stack);
    // Insert popped element
    InsertSortedStack(stack, top);
}
// function to insert sorted elements
    private static void InsertSortedStack(Stack<int> stack, int element){
        if (stack.Count == 0 || stack.Peek() <= element){
            stack.Push(element);
            return;
        }
        int top = stack.Pop();
        InsertSortedStack(stack, element);
        stack.Push(top);
    }
    static void Main(){
        Stack<int> stack = new Stack<int>();
        stack.Push(90);
        stack.Push(30);
        stack.Push(50);
        stack.Push(2);
        Console.WriteLine("Original Stack:");
        PrintStack(stack);
        SortStack(stack);
        Console.WriteLine("\nSorted Stack:");
        PrintStack(stack);
    }
    static void PrintStack(Stack<int> stack){
        int[] arr = stack.ToArray();
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
