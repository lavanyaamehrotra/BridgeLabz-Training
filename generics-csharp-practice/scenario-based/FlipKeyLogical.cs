using System;
using System.Text;
class FlipKeyLogical{
    public static string CleanseAndInvert(string input){
        if (string.IsNullOrEmpty(input) || input.Length < 6){
            return string.Empty;
        }
        foreach (char c in input){
            if (!char.IsLetter(c)){
                return string.Empty;
            }
        }
        input = input.ToLower();
        StringBuilder filtered = new StringBuilder();
        foreach (char c in input){
            if ((int)c % 2 != 0){
                filtered.Append(c);
            }
        }
        // Reverse the string
        char[] reversed = filtered.ToString().ToCharArray();
        Array.Reverse(reversed);
        // Convert even index characters to uppercase
        for (int i = 0; i < reversed.Length; i++){
            if (i % 2 == 0){
                reversed[i] = char.ToUpper(reversed[i]);
            }
        }
        return new string(reversed);
    }
    static void Main(string[] args){
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();
        string result = CleanseAndInvert(input);
        if (string.IsNullOrEmpty(result)){
            Console.WriteLine("Invalid Input");
        }
        else{
            Console.WriteLine("The generated key is - " + result);
        }
    }
}
