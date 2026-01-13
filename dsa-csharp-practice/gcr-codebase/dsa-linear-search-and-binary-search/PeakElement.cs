using System;
class PeakElement{
    static void Main(){
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        int left = 0;
        int right = n - 1;
        while (left < right){
            int mid = left + (right - left) / 2;
            if (arr[mid] < arr[mid + 1]){
                left = mid + 1; 
            }
            else{
                right = mid;
            }
        }
        Console.WriteLine($"\npeak element is {arr[left]} at index {left}");
    }
}
