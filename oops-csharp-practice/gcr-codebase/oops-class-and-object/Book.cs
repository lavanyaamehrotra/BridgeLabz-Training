using System;
class Book{
  private string title;
  private string author;
  private double price;
  // Constructor
  public Book(string title, string author, double price){
    this.title = title;
    this.author = author;
    this.price = price;
  }
  // Method to display book details
  public void DisplayDetails(){
    Console.WriteLine("Book Details:");
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Author: " + author);
    Console.WriteLine("Price: " + price);
  }
  // Main method
  static void Main(string[] args){
    // Create Book object
    Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 399.99);
    // Display details
    book.DisplayDetails();
  }
}
