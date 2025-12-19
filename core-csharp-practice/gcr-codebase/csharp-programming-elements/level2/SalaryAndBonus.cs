// 6. Create a program to find the total income of a person by taking salary and bonus from the user
class SalaryAndBonus{
  static void Main(string[] args){
    Console.WriteLine("Enter the salary:");
    double salary=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the bonus:");
    double bonus=Convert.ToDouble(Console.ReadLine());
    //formula to calculate total income
    double TotalIncome=salary+bonus;
    Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + " Hence Total Income in INR " + TotalIncome);
  }
}