using System;
using System.Collections.Generic;
class ZeroSum{
  static void FindZeroSumSubarrays(int[] arr){
    // Hash map
    Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    int sum = 0;
    // Handle subarrays
    map[0] = new List<int>();
    map[0].Add(-1);
    for (int i = 0; i < arr.Length; i++){
      sum += arr[i];
      // If sum exists, zerosum subarray found
      if (map.ContainsKey(sum)){
        foreach (int startIndex in map[sum]){
          Console.WriteLine("Zerosum subarray found from index " +(startIndex + 1) + " to " + i);
        }
      }
      // Add current index to map
      if (!map.ContainsKey(sum)){
        map[sum] = new List<int>();
      }
      map[sum].Add(i);
    }
  }
  static void Main(){
    Console.Write("Enter number of elements: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    Console.WriteLine("Enter array elements:");
    for (int i = 0; i < n; i++){
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("\nZero Sum Subarrays:");
    FindZeroSumSubarrays(arr);
  }
}
