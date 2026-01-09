using System;
using System.Collections.Generic;
class LongestConsecutiveSequence{
    static int LongestConsecutive(int[] arr){
        Dictionary<int, bool> map = new Dictionary<int, bool>();
        foreach (int num in arr){
            map[num] = true;
        }
        int maxLength = 0;
        foreach (int num in arr){
            // Start a sequence only if num-1 is not in map
            if (!map.ContainsKey(num - 1)){
                int currentNum = num;
                int length = 1;
                while (map.ContainsKey(currentNum + 1)){
                    currentNum++;
                    length++;
                }
                if (length > maxLength){
                    maxLength = length;
                }
            }
        }
        return maxLength;
    }
    static void Main(){
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int result = LongestConsecutive(arr);
        Console.WriteLine("Length of longest consecutive sequence is: " + result);
    }
}
