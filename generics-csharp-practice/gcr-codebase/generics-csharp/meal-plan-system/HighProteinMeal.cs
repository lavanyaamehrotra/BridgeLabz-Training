using System;
public class HighProteinMeal : IMealPlan{
    public string Name { get; private set; }
    public int Calories { get; private set; }
    //constructor
    public HighProteinMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }
    //display
    public void Display(){
        Console.WriteLine($"High-Protein: {Name} - {Calories} kcal");
    }
}
