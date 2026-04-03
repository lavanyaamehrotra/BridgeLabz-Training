// Toggle Case of Characters
// Problem:
// Write a C# program to toggle the case of each character in a given string. Convert
// uppercase letters to lowercase and vice versa.
using System;

class ToggleCase{
  static void Main(string [] args){
    Console.WriteLine("Enter the string:");
    string str = Console.ReadLine();
    string ans = "";
    //conversion
    for (int i = 0; i < str.Length; i++){
      char ch = str[i];
      if (char.IsUpper(ch)){
        ans += char.ToLower(ch);
      }else if (char.IsLower(ch)){
        ans += char.ToUpper(ch);
      }else{
        ans += ch; 
      }
    }
    Console.WriteLine("Toggled string is: " + ans);
  }
}
