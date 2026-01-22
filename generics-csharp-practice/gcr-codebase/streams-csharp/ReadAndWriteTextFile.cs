using System;
using System.IO;
using System.Text;
class ReadAndWriteTextFile{
    static void Main(){
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";
        try{
            // Check if source file exists
            if (!File.Exists(sourceFile)){
                Console.WriteLine("Source file does not exist.");
                return;
            }
            // Read from source file
            using (FileStream readStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream writeStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write)){
                int data;
                while ((data = readStream.ReadByte()) != -1){
                    writeStream.WriteByte((byte)data);
                }
            }
            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex){
            Console.WriteLine("File error: " + ex.Message);
        }
        Console.ReadLine();
    }
}
