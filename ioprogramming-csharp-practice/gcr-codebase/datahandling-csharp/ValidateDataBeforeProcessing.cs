using System;
using System.IO;
using System.Text.RegularExpressions;
class ValidateDataBeforeProcessing{
    static void Main(){
        string filePath = "contacts.csv";
        // Regex patterns
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Invalid Records:\n");
        // Start from 1 to skip header
        for (int i = 1; i < lines.Length; i++){
            string[] data = lines[i].Split(',');
            string email = data[2];
            string phone = data[3];
            bool isEmailValid = Regex.IsMatch(email, emailPattern);
            bool isPhoneValid = Regex.IsMatch(phone, phonePattern);
            if (!isEmailValid || !isPhoneValid){
                Console.WriteLine("Row " + i + " is invalid:");
                if (!isEmailValid){
                    Console.WriteLine("  Invalid Email: " + email);
                }
                if (!isPhoneValid){
                    Console.WriteLine("  Invalid Phone: " + phone);
                }
                Console.WriteLine();
            }
        }
    }
}
