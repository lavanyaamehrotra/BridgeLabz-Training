using System;
class HeapSort{
  //  function to sort by salary wise using Heap Sort
  static void SortSalaryUsingHeapSort(int[] salary){
    int n = salary.Length;
    for (int i = n / 2 - 1; i >= 0; i--){
      Heapify(salary, n, i);
    }
    // Extracting  elements 
    for (int i = n - 1; i > 0; i--){
      int temp = salary[0];
      salary[0] = salary[i];
      salary[i] = temp;
      Heapify(salary, i, 0);
    }
  }
  // function to ensure max heap
  static void Heapify(int[] salary, int heapSize, int rootidx){
    int largest = rootidx;       
    int leftChild = 2 * rootidx + 1;
    int rightChild = 2 * rootidx + 2;
    // Checking if left child exists and is greater than root
    if (leftChild < heapSize && salary[leftChild] > salary[largest]){
      largest = leftChild;
    }
    // Checking if right child exists and is greater than largest so far
    if (rightChild < heapSize && salary[rightChild] > salary[largest]){
      largest = rightChild;
    }
    if (largest != rootidx){
      int temp = salary[rootidx];
      salary[rootidx] = salary[largest];
      salary[largest] = temp;
      Heapify(salary, heapSize, largest);
    }
  }
  static void Main(){
    Console.Write("Enter number of employees: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] salary = new int[n];
    Console.WriteLine("Enter salary:");
    for (int i = 0; i < n; i++){
      salary[i] = Convert.ToInt32(Console.ReadLine());
    }
    SortSalaryUsingHeapSort(salary);
    Console.WriteLine("\nSorted salary");
    for (int i = 0; i < n; i++){
      Console.Write(salary[i] + " ");
    }
  }
}
