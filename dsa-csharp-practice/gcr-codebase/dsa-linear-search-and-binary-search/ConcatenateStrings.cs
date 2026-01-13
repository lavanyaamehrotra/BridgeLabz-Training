using System;
using System.Text;
class ConcatenateStrings{
    static void Main(){
        Console.Write("Enter number of strings: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] words = new string[n];
        for (int i = 0; i < n; i++){
            Console.Write("Enter string " + (i + 1) + ": ");
            words[i] = Console.ReadLine();
        }
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < n; i++){
            result.Append(words[i]);
        }
        Console.WriteLine("\nConcatenated String: " + result.ToString());
    }
}
