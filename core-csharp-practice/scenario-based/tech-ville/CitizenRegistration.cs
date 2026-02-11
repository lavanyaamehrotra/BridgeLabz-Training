using System;
class CitizenRegistration{
    static void Main(){
        // Variables
        string name;
        int age;
        double income;
        int residencyYears;
        Console.WriteLine(" Welcome to TechVille Citizen Registration Portal");
        Console.WriteLine("---------------------------------------------------");
        // Taking Input
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Annual Income: ");
        income = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Years of Residency: ");
        residencyYears = Convert.ToInt32(Console.ReadLine());
        // Validation
        if (age <= 0 || income < 0 || residencyYears < 0){
            Console.WriteLine("Invalid input detected. Please enter valid data.");
            return;
        }
        // Eligibility Score Calculation
        int eligibilityScore = 0;
        if (age >= 18 && age <= 60){
            eligibilityScore += 40;
        }
        if (income < 500000){
            eligibilityScore += 30;
        }
        if (residencyYears >= 5){
            eligibilityScore += 30;
        }
        // Output
        Console.WriteLine("\nCitizen Information Summary");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Income: {income}");
        Console.WriteLine($"Residency Years: {residencyYears}");
        Console.WriteLine($"Eligibility Score: {eligibilityScore}/100");
        if (eligibilityScore >= 60){
            Console.WriteLine("Status: Eligible for TechVille Services");
        }else{
            Console.WriteLine("Status: Not Eligible for TechVille Services");
        }
        Console.WriteLine("\nThank you for registering with TechVille!");
    }
}
