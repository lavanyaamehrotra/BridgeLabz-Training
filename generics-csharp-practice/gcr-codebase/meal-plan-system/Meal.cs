using System.Collections.Generic;
public class Meal<T> where T : IMealPlan{
    private List<T> meals = new List<T>();
    //add meal
    public void AddMeal(T meal){
        meals.Add(meal);
    }
    //display meals
    public void DisplayMeals(){
        foreach (var meal in meals)
            meal.Display();
    }
    //get meal by name
    public T GetMealByName(string name){
        return meals.Find(m => m.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
    }
    //get all meals
    public List<T> GetAllMeals(){
        return meals;
    }
}
