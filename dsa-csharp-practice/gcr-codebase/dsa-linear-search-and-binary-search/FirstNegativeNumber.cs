using System;
class FirstNegativeNumber{
    static void Main(){
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        int index = -1;
        // Linear Search for first negative number
        for (int i = 0; i < arr.Length; i++){
            if (arr[i] < 0){
                index = i;
                break;
            }
        }
        if (index != -1){
            Console.WriteLine($"First negative number is {arr[index]} at index {index}");
        }else{
            Console.WriteLine("No negative number found in the array.");
        }
    }
}
