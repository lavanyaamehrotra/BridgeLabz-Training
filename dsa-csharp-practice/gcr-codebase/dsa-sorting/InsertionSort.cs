using System;
class InsertionSort{
  //function to sort the employees 
  static void SortEmployeeIdsUsingInsertionSort(int[] arr){
    int n = arr.Length;
    for (int i = 1; i < n; i++){
      int key = arr[i];
      int j = i - 1;
      while (j >= 0 && arr[j] > key){
        arr[j + 1] = arr[j];
        j--;
      }
      arr[j + 1] = key;
    }
  }
  //Main Method
  static void Main(){
    Console.Write("Enter number of employees: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] empIDs = new int[n];
    Console.WriteLine("Enter employee Ids:");
    for (int i = 0; i < n; i++){
      empIDs[i] = Convert.ToInt32(Console.ReadLine());
    }
    SortEmployeeIdsUsingInsertionSort(empIDs);
    Console.WriteLine("\nSorted employee Ids:");
    for (int i = 0; i < n; i++){
      Console.Write(empIDs[i] + " ");
    }
    Console.WriteLine();
  }
}
