using System;
using System.Text;
class RemoveDuplicates{
    static void Main(){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        bool[] seen = new bool[256]; 
        for (int i = 0; i < str.Length; i++){
            char ch = str[i];
            if (!seen[ch]){
                seen[ch] = true;
                result.Append(ch);
            }
        }
        Console.WriteLine("String after removing duplicates: " + result.ToString());
    }
}
