using System;
using System.Collections.Generic;
public class Calculator{
    private static Dictionary<int, int> cache = new Dictionary<int, int>();
    [CacheResult]
    public int Square(int number){
        if (cache.ContainsKey(number)){
            Console.WriteLine("Returning cached result");
            return cache[number];
        }
        Console.WriteLine("Computing result...");
        int result = number * number;
        cache[number] = result;
        return result;
    }
}
