public class PartTimeEmployee : Employee{
  public int WorkHours { get; private set; }
  public decimal HourlyRate { get; private set; }
  public PartTimeEmployee(int id, string name, decimal baseSalary, int hours, decimal rate)
        : base(id, name, baseSalary){
    WorkHours = hours;
    HourlyRate = rate;
    }
    public override decimal CalculateSalary(){
    return BaseSalary + (WorkHours * HourlyRate);
    }
}