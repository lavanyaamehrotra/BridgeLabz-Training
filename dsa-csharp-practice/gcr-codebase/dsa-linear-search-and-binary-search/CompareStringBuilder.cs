using System;
using System.Diagnostics;
using System.Text;
class CompareStringBuilder{
    static void Main(){
        int iterations = 50000;
        // Using Normal String
        Stopwatch sw1 = new Stopwatch();
        sw1.Start();
        string normal = "";
        for (int i = 0; i < iterations; i++){
            normal += "a";
        }
        sw1.Stop();
        Console.WriteLine("Normal String Time: " + sw1.ElapsedMilliseconds + " ms");
        // Using StringBuilder
        Stopwatch sw2 = new Stopwatch();
        sw2.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++){
            sb.Append("a");
        }
        sw2.Stop();
        Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");
    }
}
