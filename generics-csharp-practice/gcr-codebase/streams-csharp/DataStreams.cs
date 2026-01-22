using System;
using System.IO;
class DataStreams{
    static void Main(string[] args){
        string filePath = "student.dat";
        try{
            // WRITE DATA
            using (BinaryWriter writer =new BinaryWriter(File.Open(filePath, FileMode.Create))){
                writer.Write(1);
                writer.Write("Lavanya");
                writer.Write(8.39);
            }
            Console.WriteLine("Data written.\n");
            // READ DATA
            using (BinaryReader reader =new BinaryReader(File.Open(filePath, FileMode.Open))){
                int roll = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();
                Console.WriteLine("Roll No: " + roll);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("GPA: " + gpa);
            }
        }
        catch (IOException ex){
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
