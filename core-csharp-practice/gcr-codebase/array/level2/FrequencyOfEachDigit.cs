// Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit
using System;
namespace ArrayLevel2{
  class FrequencyOfEachDigit{
    static void Main(string[] args){
      Console.WriteLine("Enter a number:");
      int number = int.Parse(Console.ReadLine());
      // convert number to string to process each digit
      string numStr = number.ToString();
      // create an array to hold frequency of digits 0-9
      int[] frequency = new int[10];
      // loop through each character 
        foreach(char digitChar in numStr){
          // convert character to integer digit
          int digit = digitChar - '0';
          // increase the frequency of the digit
          frequency[digit]++;
        }
        // display the frequency of each digit
        Console.WriteLine("Frequency of each digit:");
        for(int i = 0; i < frequency.Length; i++){
          if(frequency[i] > 0){
            Console.WriteLine("Digit " + i + ": " + frequency[i] + " time(s)");
          }
        }
    }
  }
}