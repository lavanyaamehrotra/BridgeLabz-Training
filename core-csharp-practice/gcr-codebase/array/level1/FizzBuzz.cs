// Write a program FizzBuzz, take a number as user input and if it is a positive integer loop from 0 to the number and save the number, but for multiples of 3 save "Fizz" instead of the number, for multiples of 5 save "Buzz", and for multiples of both save "FizzBuzz". Finally, print the array results for each index position in the format Position 1 = 1, …, Position 3 = Fizz,...
using System;
class FizzBuzz{
  static void Main(string[] args){
    Console.WriteLine("Enter the positive integer:");
    int number=Convert.ToInt32(Console.ReadLine());
    if(number<=0){
      Console.WriteLine("Not Valid");
      return;
    }
    string[] results=new string[number];
    //looping to check multiples of 3 and 5
    for(int i=1;i<=number;i++){
      if(i%3==0 && i%5==0){
        results[i-1]="FizzBuzz";
      }else if(i%3==0){
        results[i-1]="Fizz";
      }else if(i%5==0){
        results[i-1]="Buzz";
      }else{
        results[i-1]=i.ToString();
      }
    }
    for(int i=0;i<results.Length;i++){
      Console.WriteLine("Position " + (i+1) + " = " + results[i]);
    }
  }
}