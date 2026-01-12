using System;
class Program{
    static void Main(){
        Console.Write("Enter rod length: ");
        //rod length
        int length = int.Parse(Console.ReadLine());
        Rod rod = new Rod(length);

        PriceChart chart = new PriceChart(length);
        Console.WriteLine("\nEnter price for each length:");
        //price for each 
        for (int i = 1; i <= length; i++){
            Console.Write("Price for length " + i + ": ");
            chart.AddPrice(i, int.Parse(Console.ReadLine()));
        }
        RecursiveCutting recursive = new RecursiveCutting();
        Cutting nonOpt = new Cutting();
        Revenue visual = new Revenue();
        int bestRevenue = recursive.MaxRevenue(rod, chart);
        int normalRevenue = nonOpt.Revenue(rod, chart);
        Console.WriteLine("\nBest Revenue Using Recursion = rs" + bestRevenue);
        Console.WriteLine("Revenue Without Cutting= rs" + normalRevenue);
        visual.Display(bestRevenue, normalRevenue);
    }
}
