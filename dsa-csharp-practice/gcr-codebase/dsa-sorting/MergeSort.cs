using System;
class MergeSort{
  static void MergeSortBooks(int[] prices, int left, int right){
    if (left < right){
      // Find the middle index
      int mid = (left + right) / 2;
      // Recursively sort the left half
      MergeSortBooks(prices, left, mid);
      // Recursively sort the right half
      MergeSortBooks(prices, mid + 1, right);
      // Merge the two sorted halves
      Merge(prices, left, mid, right);
    }
  }
  static void Merge(int[] prices, int left, int mid, int right){
    int leftSize = mid - left + 1;
    int rightSize = right - mid;
    // Creating temporary arrays
    int[] leftArray = new int[leftSize];
    int[] rightArray = new int[rightSize];
    for (int i = 0; i < leftSize; i++){
      leftArray[i] = prices[left + i];
    }
    for (int j = 0; j < rightSize; j++){
      rightArray[j] = prices[mid + 1 + j];
    }
    int LeftIndex = 0;   
    int RightIndex = 0;   
    int k = left;    
    // Compare elements and merge them in sorted order
    while (LeftIndex < leftSize && RightIndex < rightSize){
      if (leftArray[LeftIndex] <= rightArray[RightIndex]){
        prices[k] = leftArray[LeftIndex];
        LeftIndex++;
      }else{
        prices[k] = rightArray[RightIndex];
        RightIndex++;
      }
      k++;
    }
    while (LeftIndex < leftSize){
      prices[k] = leftArray[LeftIndex];
      LeftIndex++;
      k++;
    }
    while (RightIndex < rightSize){
      prices[k] = rightArray[RightIndex];
      RightIndex++;
      k++;
    }
  }
  //Main method
  static void Main(){
    Console.Write("Enter number of books: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] prices = new int[n];
    Console.WriteLine("Enter book prices:");
    for (int i = 0; i < n; i++){
      prices[i] = Convert.ToInt32(Console.ReadLine());
    }
    MergeSortBooks(prices, 0, n - 1);
    Console.WriteLine("\nSorted book prices:");
    for (int i = 0; i < n; i++){
      Console.Write(prices[i] + " ");
    }
  }
}
