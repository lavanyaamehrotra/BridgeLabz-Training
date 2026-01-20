using System;
public class KetoMeal : IMealPlan{
    public string Name { get; private set; }
    public int Calories { get; private set; }
    // constructor
    public KetoMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }
    public void Display(){
        Console.WriteLine($"[Keto] {Name} - {Calories} kcal");
    }
}
