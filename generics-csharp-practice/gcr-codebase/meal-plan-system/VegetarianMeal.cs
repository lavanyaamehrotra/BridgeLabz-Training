using System;

public class VegetarianMeal : IMealPlan{
    public string Name { get; private set; }
    public int Calories { get; private set; }
    // constructor
    public VegetarianMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }
    //display
    public void Display(){
        Console.WriteLine($"[Vegetarian] {Name} - {Calories} kcal");
    }
}
