using System;
class Program{
    public static void Main(string[] args) {
        Console.WriteLine("=============PERSONALIZED MEAL PLAN GENERATOR ===========\n");
        var vegMeals = new Meal<VegetarianMeal>();
        var veganMeals = new Meal<VeganMeal>();
        var ketoMeals = new Meal<KetoMeal>();
        var proteinMeals = new Meal<HighProteinMeal>();
        bool exit = false;
        while (!exit){
            Console.WriteLine("\n1. Add Vegetarian Meal");
            Console.WriteLine("2. Add Vegan Meal");
            Console.WriteLine("3. Add Keto Meal");
            Console.WriteLine("4. Add High-Protein Meal");
            Console.WriteLine("5. View All Meals");
            Console.WriteLine("6. Search Meal");
            Console.WriteLine("7. Exit");
            Console.Write("\nEnter choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    MealService.GenerateMealPlan(vegMeals);
                    break;
                case 2:
                    MealService.GenerateMealPlan(veganMeals);
                    break;
                case 3:
                    MealService.GenerateMealPlan(ketoMeals);
                    break;
                case 4:
                    MealService.GenerateMealPlan(proteinMeals);
                    break;
                case 5:
                    Console.WriteLine("\n--- Vegetarian Meals ---");
                    vegMeals.DisplayMeals();
                    Console.WriteLine("\n--- Vegan Meals ---");
                    veganMeals.DisplayMeals();
                    Console.WriteLine("\n--- Keto Meals ---");
                    ketoMeals.DisplayMeals();
                    Console.WriteLine("\n--- High-Protein Meals ---");
                    proteinMeals.DisplayMeals();
                    break;
                case 6:
                    Console.Write("\nEnter meal name to search: ");
                    string name = Console.ReadLine();
                    var found =
                        vegMeals.GetMealByName(name) ??
                        veganMeals.GetMealByName(name) ??
                        ketoMeals.GetMealByName(name) ??
                        proteinMeals.GetMealByName(name);
                    if (found != null){
                        found.Display();
                    }else{
                        Console.WriteLine("Meal not found!");
                    }
                    break;
                case 7:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
