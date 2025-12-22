// Create a program to print odd and even numbers between 1 to the number entered by the user.
// Hint => 
// Get an integer input from the user, assign to a variable number and check for Natural Number
// Using a for loop, iterate from 1 to the number
// In each iteration of the loop, print the number is odd or even number
using System;
class OddOrEven{
  static void Main(string [] args){
    Console.WriteLine("Enter a natural number");
    int number=Convert.ToInt32(Console.ReadLine());
    //checking whether the number is natural number
    if(number<1){
      Console.WriteLine("Wrong input");
    }else{
      for(int i=1;i<=number;i++){
        //checking whether the number is odd or even
        if(i%2==0){
          Console.WriteLine(i + " is an even number");
        }else{
          Console.WriteLine(i + " is an odd number");
        }
      }
    }
  }
}