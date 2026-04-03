using System;
using System.Diagnostics;
using System.IO;
class EfficientFileCopy{
    static void Main(){
        string sourceFile = "largefile.dat"; 
        string normalCopy = "normalCopy.dat";
        string bufferedCopy = "bufferedCopy.dat";
        CopyUsingFileStream(sourceFile, normalCopy);
        CopyUsingBufferedStream(sourceFile, bufferedCopy);
        Console.ReadLine();
    }
    // NORMAL FILESTREAM COPY
    static void CopyUsingFileStream(string source, string destination){
        byte[] buffer = new byte[4096];
        Stopwatch sw = Stopwatch.StartNew();
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write)){
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0){
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        Console.WriteLine("Normal FileStream Time: " + sw.ElapsedMilliseconds + " ms");
    }
    // BUFFERED STREAM COPY
    static void CopyUsingBufferedStream(string source, string destination){
        byte[] buffer = new byte[4096];
        Stopwatch sw = Stopwatch.StartNew();
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsRead = new BufferedStream(fsRead))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite)){
            int bytesRead;
            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0){
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        Console.WriteLine("BufferedStream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
