 //Create a program to find the bonus of 10 employees based on their years of service as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus, along with the old and new salary.

using System;
class Bonus{
    // Generate Salary & Years of Service
    public static double[,] GenerateEmployeeData(int n){
        Random rand = new Random();
        double[,] data = new double[n, 2];

        for (int i = 0; i < n; i++){
            int salary = rand.Next(10000, 99999); 
            int years = rand.Next(0, 11);  
            data[i, 0] = salary;
            data[i, 1] = years;
        }
        return data;
    }

    //Calculate Bonus & New Salary
    public static double[,] CalculateBonusAndNewSalary(double[,] oldData){
        int n = oldData.GetLength(0);
        double[,] newData = new double[n, 2];

        for (int i = 0; i < n; i++){
            double salary = oldData[i, 0];
            double years = oldData[i, 1];
            double bonus = (years > 5) ? salary * 0.05 : salary * 0.02;
            double newSalary = salary + bonus;
            newData[i, 0] = bonus;
            newData[i, 1] = newSalary;
        }
        return newData;
    }

    // Display Table & Totals
    public static void DisplayTable(double[,] oldData, double[,] newData){
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;
        Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");
        for (int i = 0; i < oldData.GetLength(0); i++){
            double oldSalary = oldData[i, 0];
            double years = oldData[i, 1];
            double bonus = newData[i, 0];
            double newSalary = newData[i, 1];
            totalOldSalary += oldSalary;
            totalBonus += bonus;
            totalNewSalary += newSalary;
            Console.WriteLine($"{i + 1}\t{oldSalary:0}\t\t{years:0}\t{bonus:0}\t\t{newSalary:0}");
        }
        Console.WriteLine($"TOTAL\t{totalOldSalary:0}\t\t\t{totalBonus:0}\t\t{totalNewSalary:0}");
    }

    static void Main(){
        int employees = 10;
        double[,] employeeData = GenerateEmployeeData(employees);
        double[,] bonusData = CalculateBonusAndNewSalary(employeeData);
        DisplayTable(employeeData, bonusData);
        Console.ReadLine();
    }
}
