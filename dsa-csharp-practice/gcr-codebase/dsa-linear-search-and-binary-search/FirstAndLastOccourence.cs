using System;

class FirstAndLastOccurrence{
    static void Main(){
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter sorted elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter target element: ");
        int target = int.Parse(Console.ReadLine());
        int first = FindFirst(arr, target);
        int last = FindLast(arr, target);
        if (first == -1){
            Console.WriteLine("\ntarget element not found.");
        }else{
            Console.WriteLine($"\nFirst Occurrence at index: {first}");
            Console.WriteLine($"Last Occurrence at index: {last}");
        }
    }
    //find first
    static int FindFirst(int[] arr, int target){
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;
        while (left <= right){
            int mid = (left + right) / 2;
            if (arr[mid] == target){
                result = mid;
                right = mid - 1;  
            }
            else if (arr[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }
        return result;
    }
    //find last 
    static int FindLast(int[] arr, int target){
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;
        while (left <= right){
            int mid = (left + right) / 2;
            if (arr[mid] == target){
                result = mid;
                left = mid + 1;  
            }
            else if (arr[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }
        return result;
    }
}
