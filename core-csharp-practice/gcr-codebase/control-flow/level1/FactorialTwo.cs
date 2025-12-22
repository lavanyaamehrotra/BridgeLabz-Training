// Rewrite program 14 using for loop
using System;
class FactorialTwo{
  static void Main(string [] args){  
    int fact=1;  
    Console.WriteLine("Enter a positive integer");  
    int number=Convert.ToInt32(Console.ReadLine());  
    //checking whether the number is positive integer
    if(number<0){
      Console.WriteLine("Wrong input");
    }else{
      //calculating factorial using for loop
      for(int i=1;i<=number;i++){    
        fact=fact*i;    
      }    
      Console.WriteLine("The factorial of " + number + " is: " + fact);  
    }  
  }  
}