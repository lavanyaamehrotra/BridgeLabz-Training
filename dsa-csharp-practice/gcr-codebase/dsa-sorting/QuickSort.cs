using System;
class QuickSort{
  // Function to sort
  static void SortProductPricesUsingQuickSort(int[] prices, int low, int high){
    if (low < high){
      int pivotidx = Partition(prices, low, high);
      // Recursively sort elements before pivot
      SortProductPricesUsingQuickSort(prices, low, pivotidx - 1);
      // Recursively sort elements after pivot
      SortProductPricesUsingQuickSort(prices, pivotidx + 1, high);
    }
  }
  //function to place the pivot at correct position
  static int Partition(int[] prices, int low, int high){
    int pivot = prices[high];
    int i = low - 1;  
    // Move elements smaller than pivot to the left
    for (int j = low; j < high; j++){
      if (prices[j] < pivot){
        i++;
        int temp = prices[i];
        prices[i] = prices[j];
        prices[j] = temp;
      }
    }
    // Placing pivot at correct position
    int tempPivot = prices[i + 1];
    prices[i + 1] = prices[high];
    prices[high] = tempPivot;
    // return pivot index
    return i + 1; 
  }
  static void Main(){
    Console.Write("Enter number of products: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] prices = new int[n];
    Console.WriteLine("Enter product prices:");
    for (int i = 0; i < n; i++){
      prices[i] = Convert.ToInt32(Console.ReadLine());
    }
    SortProductPricesUsingQuickSort(prices, 0, n - 1);
    Console.WriteLine("\nSorted product price:");
    for (int i = 0; i < n; i++){
      Console.Write(prices[i] + " ");
    }
  }
}
