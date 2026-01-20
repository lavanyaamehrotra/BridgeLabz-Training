using System;
public static class MealService{
    public static void GenerateMealPlan<T>(Meal<T> mealCatalog) where T : IMealPlan{
        Console.Write("\nEnter meal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter calories: ");
        int calories = int.Parse(Console.ReadLine());
        T meal = (T)Activator.CreateInstance(typeof(T), name, calories);
        mealCatalog.AddMeal(meal);
        Console.WriteLine("Meal added successfully!");
    }
}
