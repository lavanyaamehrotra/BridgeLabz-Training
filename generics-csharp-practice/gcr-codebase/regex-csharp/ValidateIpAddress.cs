using System;
using System.Text.RegularExpressions;
class ValidateIpAddress{
    static void Main(string[] args){
        Console.WriteLine("Enter an IPv4 address:");
        string ip = Console.ReadLine();
        string pattern ="^((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])\\.){3}" + "(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])$";
        if(Regex.IsMatch(ip, pattern)){
            Console.WriteLine("Valid IPv4 Address");
        }
        else{
            Console.WriteLine("Invalid IPv4 Address");
        }
        Console.ReadLine();
    }
}
