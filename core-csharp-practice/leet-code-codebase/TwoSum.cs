using System;
class TwoSum{
  static void Main(){
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    for (int i = 0; i < n; i++){
        arr[i] = int.Parse(Console.ReadLine());
    }
    int target = int.Parse(Console.ReadLine());
    // to track if any pair sums to target
    bool found = false; 
    for (int i = 0; i < n; i++){
      for (int j = i + 1; j < n; j++){
        if (arr[i] + arr[j] == target){
          Console.WriteLine("yes");
          found = true;
          // exit inner loop once a pair is found
          break;
        }
      }
      // exit outer loop once a pair is found
      if (found) break;
    }
    if (!found){
      Console.WriteLine("NO");
    }
  }
}
