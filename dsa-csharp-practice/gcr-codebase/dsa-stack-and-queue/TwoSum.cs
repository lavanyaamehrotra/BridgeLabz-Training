using System;
using System.Collections.Generic;
class TwoSum{
  static void FindTwoSum(int[] arr, int target){
    Dictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++){
      int complements = target - arr[i];
      if (map.ContainsKey(complements)){
        Console.WriteLine($"Pair found at: {map[complements]} and {i}");
        return;
      }
      // Store current element with its index
      if (!map.ContainsKey(arr[i])){
        map[arr[i]] = i;
      }
    }
    Console.WriteLine("No pair found");
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
    FindTwoSum(arr, target);
  }
}
