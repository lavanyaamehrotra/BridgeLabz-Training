// Count Vowels and Consonants
// Problem:
// Write a C# program to count the number of vowels and consonants in a given string.
using System;
class VowelsAndConsonants{
  static void Main(string[] args){
    Console.Write("Enter a string: ");
    string str = Console.ReadLine();
    int vowels = 0;
    int consonants = 0;
    str = str.ToLower();
    //finding vowels and consonants
    foreach (char ch in str){
      if (ch >= 'a' && ch <= 'z'){
        if (ch == 'a' || ch == 'e' || ch == 'i' ||ch == 'o' || ch == 'u'){
          vowels++;
        }else{
          consonants++;
        }
      }
    }
    Console.WriteLine("Vowels: " + vowels);
    Console.WriteLine("Consonants: " + consonants);
  }
}
