using System;
class SlidingWindow{
  static void MaximumSlidingWindow(int[] arr, int k){
    int n = arr.Length;
    // used for storing indices
    LinkedList<int> deque = new LinkedList<int>(); 
    for (int i = 0; i < n; i++){
      // Remove indices out of window
      if (deque.Count > 0 && deque.First.Value <= i - k){
        deque.RemoveFirst();
      }
      // Remove smaller elements from back
      while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i]){
        deque.RemoveLast();
      }
      // Add current index
      deque.AddLast(i);
      // Print max for each window
      if (i >= k - 1){
        Console.Write(arr[deque.First.Value] + " ");
      }
    }
    Console.WriteLine();
  }
  static void Main(){
    Console.Write("Enter number of elements: ");
    int n =Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    Console.WriteLine("Enter elements of array:");
    for (int i = 0; i < n; i++){
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Enter window size: ");
    int k = Convert.ToInt32(Console.ReadLine());
    if (k > n || k <= 0){
      Console.WriteLine("Invalid size of window");
      return;
    }
    Console.WriteLine("Sliding Window:");
    MaximumSlidingWindow(arr, k);
  }
}
