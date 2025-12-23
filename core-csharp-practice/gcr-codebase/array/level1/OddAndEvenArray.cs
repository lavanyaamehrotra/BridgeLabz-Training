// Create a program to save odd and even numbers into odd and even arrays between 1 to the number entered by the user. Finally, print the odd and even numbers array
using System;
class OddAndEvenArray{
  static void Main(string[] args){
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0){
      Console.WriteLine("Not Valid");
      return;
    }
    // Create arrays
    int[] even = new int[number / 2 + 1];
    int[] odd = new int[number / 2 + 1];
    // Index variables
    int evenindex = 0;
    int oddindex = 0;
    for (int i = 1; i <= number; i++){
      if (i % 2 == 0){
        even[evenindex] = i;
        evenindex++;
      }else{
        odd[oddindex] = i;
        oddindex++;
      }
    }
    // Print odd numbers
    Console.WriteLine("Odd numbers are ");
    for (int i = 0; i < oddindex; i++){
      Console.Write(odd[i] + " ");
    }
    // Print even numbers
    Console.WriteLine("Even numbers: ");
    for (int i = 0; i < evenindex; i++){
      Console.Write(even[i] + " ");
    } 
  }
}
