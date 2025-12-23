// Write a program to take user input for 5 numbers and check whether a number is positive,  negative, or zero. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they equal, greater or less
using Scanner;
class PositiveNegativeAndZero{
  static void Main(string[] args){
    int [] numbers=new int[5];
    for(int i=0;i<numbers.Length;i++){
      Console.WriteLine("Enter number " + (i+1) + ":");
      numbers[i]=Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<numbers.Length;i++){
      if(numbers[i]>0){
        if(numbers[i]%2==0){
          Console.WriteLine(numbers[i] + " is a positive even number.");
        }else{
          Console.WriteLine(numbers[i] + " is a positive odd number.");
        }
      }else if(numbers[i]<0){
        Console.WriteLine(numbers[i] + " is a negative number.");
      }else{
        Console.WriteLine("The number is zero.");
      }
    }
  }
}