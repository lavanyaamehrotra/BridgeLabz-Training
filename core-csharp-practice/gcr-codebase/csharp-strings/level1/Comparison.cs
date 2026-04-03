// Compare Two Strings Using charAt()
// Take user input using Console.ReadLine().
// Create a method to compare two strings using CharAt() logic (string[index] in C#).
// Compare the result with the built-in string.Equals().
using System;
class Comparison{
  static bool Comparing(string s1, string s2){
    if(s1==null || s2==null)
      return false;
    if (s1.Length != s2.Length)
      return false;
    for (int i = 0; i < s1.Length; i++){
      if (s1[i] != s2[i])
        return false;
    }
    return true;
  }
  static void Main(string[] args){
    Console.Write("Enter first string: ");
    string str1 = Console.ReadLine();
    Console.Write("Enter second string: ");
    string str2 = Console.ReadLine();
    bool result = Comparing(str1, str2);
    bool equalresult = string.Equals(str1, str2);
    Console.WriteLine($"result : {result}");
    Console.WriteLine($".Equals() result: {equalresult}");
    Console.WriteLine(result == equalresult? "\nBoth methods give same result ": "\nMethods give different result");
  }
}
