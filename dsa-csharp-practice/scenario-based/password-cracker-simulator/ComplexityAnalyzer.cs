using System;
public class ComplexityAnalyzer {
    public void Explain(int k, int n){
        Console.WriteLine("\n--- Complexity Analysis ---");
        Console.WriteLine("Time Complexity : O(" + k + "^" + n + ")");
        Console.WriteLine("Space Complexity: O(" + n + ")");
    }
}

