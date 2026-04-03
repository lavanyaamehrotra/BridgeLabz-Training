using System;
using System.Text.RegularExpressions;
class HexxColorCode{
    static void Main(string[] args){
        Console.Write("Enter hex color code: ");
        string colorCode = Console.ReadLine();
        string pattern = "^#[0-9A-Fa-f]{6}$";
        // Validate hex color code
        if(Regex.IsMatch(colorCode, pattern)){
            Console.WriteLine("Valid Hex Color Code");
        }else{
            Console.WriteLine("Invalid Hex Color Code");
        }
        Console.ReadLine();
    }
}
