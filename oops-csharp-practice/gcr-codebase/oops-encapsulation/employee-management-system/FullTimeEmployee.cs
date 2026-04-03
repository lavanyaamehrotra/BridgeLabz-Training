public class FullTimeEmployee : Employee{
  public decimal FixedMonthlySalary{get; private set;}
  public FullTimeEmployee(int id,string name,decimal baseSalary,decimal fixedSalary) : base(id, name, baseSalary){
    FixedMonthlySalary=fixedSalary;
  }
  public override decimal CalculateSalary(){
    return BaseSalary+FixedMonthlySalary;
  }
}