using System;
using System.Diagnostics;
class LinearSearchVsBinarySearch{
    //Linear search
    static int LinearSearch(int[] arr, int target){
        for (int i = 0; i < arr.Length; i++){
            if (arr[i] == target){
                return i;
            }
        }
        return -1;
    }
    //Binary search
    static int BinarySearch(int[] arr, int target){
        int left = 0;
        int  right = arr.Length - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            if (arr[mid] == target){
                return mid;
            }
            else if (arr[mid] < target){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return -1;
    }
    //compare
    static void Find(int size){
        int[] arr = new int[size];
        for (int i = 0; i < size; i++){
            arr[i] = i + 1;
        }
        int target = size - 1;  // Worst case for linear search
        Stopwatch sw = new Stopwatch();
        // Linear Search
        sw.Start();
        LinearSearch(arr, target);
        sw.Stop();
        long linearTime = sw.ElapsedMilliseconds;
        // Binary Search
        sw.Restart();
        BinarySearch(arr, target);
        sw.Stop();
        long binaryTime = sw.ElapsedMilliseconds;
        Console.WriteLine($"{size,-12} {linearTime,-15} {binaryTime,-15}");
    }
    static void Main(){
        Console.WriteLine("Dataset Size   Linear Search(ms) Binary Search(ms)");
        Find(1000);
        Find(10000);
        Find(1000000);
        Console.ReadLine();
    }
}
