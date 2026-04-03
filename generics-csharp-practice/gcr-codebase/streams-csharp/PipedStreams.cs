using System;
using System.IO;
class PipedStreams{
    public static void Main(){
        string file = "student.dat";
        using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create))){
            bw.Write(1);
            bw.Write("Lavanya");
            bw.Write(8.39);
        }
        using (BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open))){
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
