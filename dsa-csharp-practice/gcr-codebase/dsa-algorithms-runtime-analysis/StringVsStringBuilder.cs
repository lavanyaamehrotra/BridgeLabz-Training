using System;
using System.Diagnostics;
using System.Text;

class StringConcatenation{
    static void TestConcat(int n){
        Stopwatch sw = new Stopwatch();
        // Using string (O(N^2))
        string s = "";
        sw.Start();
        for (int i = 0; i < n; i++)
            s += "a";
        sw.Stop();
        long stringTime = sw.ElapsedMilliseconds;
        // Using StringBuilder (O(N))
        StringBuilder sb = new StringBuilder();
        sw.Restart();
        for (int i = 0; i < n; i++)
            sb.Append("a");
        sw.Stop();
        long builderTime = sw.ElapsedMilliseconds;
        Console.WriteLine($"{n,-12} {stringTime,-15} {builderTime,-15}");
    }

    static void Main(){
        Console.WriteLine("Operations(N)  string(ms)      StringBuilder(ms)");
        TestConcat(1000);
        TestConcat(10000);
        TestConcat(1000000);
        Console.ReadLine();
    }
}
