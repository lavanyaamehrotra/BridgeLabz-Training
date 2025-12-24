// Create a program to find the factors of a number taken as user input, store the factors in an array, and display the factors
using System;
class Factors{
  static void Main(string[] args){
    Console.WriteLine("Enter a number to find its factors:");
    int number=Convert.ToInt32(Console.ReadLine());
    int maxFactor=10;
    int[] factors=new int[maxFactor];
    int index=0;
    //loop to find the factors of the numbers
    for(int i=1;i<=number;i++){
      if(number%i==0){
        if(index==maxFactor){
          maxFactor*=2;
          int[] temp=new int[maxFactor];
          //copy the previous factors to the new factors array
          for(int j=0;j<factors.Length;j++){
            temp[j]=factors[j];
          }
          factors=temp;
        }
        factors[index]=i;
        index++;
      }
    }
    Console.WriteLine("The factors of " + number + " are:");
    for(int i=0;i<index;i++){
      Console.WriteLine(factors[i]);
    }
  }
}
