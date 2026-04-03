using System;
public class Product<TCategory> where TCategory : ProductCategory{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public TCategory Category { get; set; }
    //constructor
    public Product(int id, string name, double price, TCategory category){
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }
    //display
    public void Display(){
        Console.WriteLine($"ID: {Id}, Name: {Name}, Price: ₹{Price}");
        Category.DisplayCategory();
    }
}
