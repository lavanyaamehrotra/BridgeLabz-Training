// Write a Program to find the factorial of an integer entered by the user.
using System;
class Factorial{  
  static void Main(string [] args){  
    int fact=1;  
    Console.WriteLine("Enter a positive integer");  
    int number=Convert.ToInt32(Console.ReadLine());  
    //checking whether the number is positive integer
    if(number<0){
      Console.WriteLine("Wrong input");
    }else{
      int i=1;  
      //calculating factorial using while loop
      while(i<=number){    
        fact=fact*i;    
        i++;    
      }    
      Console.WriteLine("The factorial of " + number + " is: " + fact);  
    }  
  }  
}