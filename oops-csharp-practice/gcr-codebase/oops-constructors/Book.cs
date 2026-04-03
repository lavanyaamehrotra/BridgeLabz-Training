using System;
class Book{
  // Attributes
  public string Title;
  public string Author;
  public double Price;
  // Default constructor
  public Book(){
    Title = "Unknown";
    Author = "Unknown";
    Price = 0.0;
  }
  // Parameterized constructor
  public Book(string title, string author, double price){
    Title = title;
    Author = author;
    Price = price;
  }
  // Method to display book details
  public void Display(){
    Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price:C}");
  }
}
// Testing the Book class
class Program{
  static void Main(string[] args){
    // Using default constructor
    Book book1 = new Book();
    book1.Display();
    // Using parameterized constructor
    Book book2 = new Book("The Alchemist", "Paulo Coelho", 299.99);
    book2.Display();
  }
}
