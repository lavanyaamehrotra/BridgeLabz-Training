using System;
using System.Diagnostics;
using System.Reflection;
class Program{
    static void Main(){
        PerformanceTest test = new PerformanceTest();
        foreach (MethodInfo method in typeof(PerformanceTest).GetMethods()){
            if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null){
                Stopwatch sw = Stopwatch.StartNew();
                method.Invoke(test, null);
                sw.Stop();
                Console.WriteLine($"{method.Name} took {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}
