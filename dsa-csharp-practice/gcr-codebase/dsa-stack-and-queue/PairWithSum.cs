using System;
using System.Collections.Generic;
class PairWithSum{
  static bool HasPairWithSum(int[] arr, int target){
    Dictionary<int, bool> map = new Dictionary<int, bool>();
    for (int i = 0; i < arr.Length; i++){
      int remainingSum = target - arr[i];
      if (map.ContainsKey(remainingSum)){
        Console.WriteLine($"Pair found: ({arr[i]}, {remainingSum})");
        return true;
      }
      // Store the current number
      if (!map.ContainsKey(arr[i])){
        map[arr[i]] = true;
      }
    }
    return false;
  }
  static void Main(){
    Console.Write("Enter number of elements: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    Console.WriteLine("Enter array elements:");
    for (int i = 0; i < n; i++){
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Enter target sum: ");
    int target = Convert.ToInt32(Console.ReadLine());
    if (!HasPairWithSum(arr, target)){
      Console.WriteLine("No pair found");
    }
  }
}
