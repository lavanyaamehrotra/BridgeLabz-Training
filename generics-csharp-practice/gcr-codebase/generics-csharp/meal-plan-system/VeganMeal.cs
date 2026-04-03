using System;
public class VeganMeal : IMealPlan{
    public string Name { get; private set; }
    public int Calories { get; private set; }
    
    // constructor
    public VeganMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }
    //display
    public void Display(){
        Console.WriteLine($"[Vegan] {Name} - {Calories} kcal");
    }
}
