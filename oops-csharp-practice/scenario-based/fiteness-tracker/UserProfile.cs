public class UserProfile{
  public string Name { get; set; }
  public int Age { get; set; }
  public double Weight { get; set; }
  public UserProfile(string name, int age, double weight){
    Name = name;
    Age = age;
    Weight = weight;
  }
  //display profile
  public void DisplayProfile(){
    Console.WriteLine($"User: {Name}, Age: {Age}, Weight: {Weight}kg");
  }
}
