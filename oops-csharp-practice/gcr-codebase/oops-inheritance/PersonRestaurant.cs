using System;
// Superclass
class PersonRestaurant{
  public string Name;
  public int Id;
  public PersonRestaurant(string name,int id){
    Name = name;
    Id = id;
  }
  public void DisplayPersonDetails(){
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("ID: " + Id);
  }
}

// Interface — Worker
interface Worker{
  void PerformDuties();
}
// Subclass 1 — Chef
class Chef : PersonRestaurant, Worker{
  public string Specialty;
  public Chef(string name, int id, string specialty): base(name, id){
    Specialty = specialty;
  }
  public void PerformDuties(){
    Console.WriteLine("\nRole: Chef");
    DisplayPersonDetails();
    Console.WriteLine("Specialty: " + Specialty);
    Console.WriteLine("Duties: Prepares meals and manages kitchen");
  }
}
// Subclass 2 — Waiter
class Waiter : PersonRestaurant, Worke{
  public string Shift;
  public Waiter(string name, int id, string shift): base(name, id){
    Shift = shift;
  }
  public void PerformDuties(){
    Console.WriteLine("\nRole: Waiter");
    DisplayPersonDetails();
    Console.WriteLine("Shift: " + Shift);
    Console.WriteLine("Duties: Serves customers and takes orders.");
  }
}

// Main Class
class RestaurantSystem{
    static void Main(string[] args){
      Chef chef1 = new Chef("Lavanya", 101, "Italian Cuisine");
      Waiter waiter1 = new Waiter("Sneha", 205, "Evening Shift");
      chef1.PerformDuties();
      waiter1.PerformDuties();
    }
}
