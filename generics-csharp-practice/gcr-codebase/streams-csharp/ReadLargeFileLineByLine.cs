using System;
using System.IO;
class ReadLargeFileLineByLine{
    static void Main(){
        string filePath = "largefile.txt";
        try{
            using (StreamReader reader = new StreamReader(filePath)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0){
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine("Error reading file: " + ex.Message);
        }
        Console.ReadLine();
    }
}
