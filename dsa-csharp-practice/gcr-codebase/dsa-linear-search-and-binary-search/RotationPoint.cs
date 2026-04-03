using System;
class RotationPoint{
    static void Main(){
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the rotated elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        int left = 0;
        int right = n - 1;
        while (left < right){
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[right]){
                left = mid + 1;
            }else{
                right = mid;
            }
        }
        Console.WriteLine($"\nrotation point found at index {left}");
        Console.WriteLine($"smallest element is {arr[left]}");
    }
}
