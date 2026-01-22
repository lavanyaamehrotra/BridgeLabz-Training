using System;
using System.IO;
using System.Text;
class ConvertingUppercasetoLowerCase{
    static void Main(){
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";
        try{
            // Open source file with BufferedStream + StreamReader
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8)){
                // Open destination file with BufferedStream + StreamWriter
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsWrite = new BufferedStream(fsWrite))
                using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8)){
                    string? line;
                    while ((line = reader.ReadLine()) != null){
                        writer.WriteLine(line.ToLower());
                    }
                }
            }
            Console.WriteLine("File converted to lowercase successfully.");
        }
        catch (IOException ex){
            Console.WriteLine("File error: " + ex.Message);
        }
        Console.ReadLine();
    }
}
