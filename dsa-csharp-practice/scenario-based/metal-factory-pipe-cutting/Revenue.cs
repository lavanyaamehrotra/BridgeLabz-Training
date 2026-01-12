public class Revenue{
    //function to display
    public void Display(int ptimized , int nonOptimized){
        Console.WriteLine("\n----- Revenue Report -----");
        Console.WriteLine("Optimized Revenue     : Rs" + optimized);
        Console.WriteLine("Non-Optimized Revenue : Rs" + nonOptimized);
        int loss = optimized - nonOptimized;
        Console.WriteLine("Revenue Loss Without Optimization : $" + loss);
    }
}