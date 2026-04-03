using System;
using System.IO;
class ReadUserInputFromConsole{
    static void Main(){
        string filePath = "userdetails.txt";
        try{
            // StreamReader for console input
            StreamReader input = new StreamReader(Console.OpenStandardInput());
            Console.Write("Enter your name: ");
            string name = input.ReadLine();
            Console.Write("Enter your age: ");
            string age = input.ReadLine();
            Console.Write("Enter your favorite programming language: ");
            string language = input.ReadLine();
            // StreamWriter to write into file
            using (StreamWriter writer = new StreamWriter(filePath)){
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Language: " + language);
            }
            Console.WriteLine("\nData saved successfully into file.");
        }
        catch (IOException ex){
            Console.WriteLine("File error: " + ex.Message);
        }
        Console.ReadLine();
    }
}
