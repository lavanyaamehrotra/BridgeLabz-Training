public abstract class Employee : IDepartment{
  private int employeeId;
  private string name;
  private decimal BaseSalary;
  private string department;
  public int EmployeeId{
    get=> employeeId;
    protected set => employeeId=value;
  }
  public string Name{
    get => name;
    protected set => name=value;
  }
  public decimal BaseSalary{
    get => baseSalary;
    protected set => baseSalary=value;
  }
  protected Employee(int id ,string name,decimal baseSalary){
    EmployeeId=id;
    Name=name;
    BaseSalary=baseSalary;
  }
  public abstract decimal CalculateSalary();
  public virtual void DisplayDetails(){
    Console.WriteLine($"Employee ID : {EmployeeId}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Base Salary: {BaseSalary}");
    Console.WriteLine($"Department: {GetDepartmentDetails()}");
    Console.WriteLine($"Final Salary: {CalculateSalary()}");
  }
  public void AssignDepartment(string departmentName){
    department=departmentName;
  }
  public string GetDepartmentDetails(){
    return string.IsNullOrEmpty(department) ? "Not Assigned":department;
  }
}