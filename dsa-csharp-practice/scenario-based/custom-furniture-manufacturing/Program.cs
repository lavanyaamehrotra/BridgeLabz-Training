using System;
class Program{
    static void Main(){
        Console.Write("Enter wooden rod length: ");
        //wooden rod length
        int length = int.Parse(Console.ReadLine());
        WoodRod rod = new WoodRod(length);
        //price chart 
        PriceChart chart = new PriceChart(length);
        // price of wooden rod
        for (int i = 1; i <= length; i++){
            Console.Write("Enter price for " + i + "ft: ");
            chart.AddPrice(i, int.Parse(Console.ReadLine()));
        }
        FurnitureCutting normal = new FurnitureCutting();
        int best = normal.MaxRevenue(rod, chart);
        Console.WriteLine("\nScenario A - Max Revenue = rs" + best);
        Console.Write("\nEnter allowed waste: ");
        int waste = int.Parse(Console.ReadLine());
        WasteAwareCutting wasteCut = new WasteAwareCutting();
        int bestWaste = wasteCut.MaxRevenueWithWaste(rod, chart, waste);
        Console.WriteLine("Scenario B - Revenue with Waste Constraint = rs" + bestWaste);
        CutSuggestion suggest = new CutSuggestion();
        suggest.SuggestCuts(length, chart);
    }
}
