using System;
class Book{
  // Static variable shared across all books
  public static string LibraryName = "Lavanya's Library";
  // Readonly variable for ISBN
  public readonly string ISBN;
  // Instance variables
  public string Title;
  public string Author;
  // Constructor 
  public Book(string Title, string Author, string ISBN){
    this.Title = Title;   
    this.Author = Author; 
    this.ISBN = ISBN;     
  }
  // Static method to display library name
  public static void DisplayLibraryName(){
    Console.WriteLine($"Library Name: {LibraryName}");
  }
  // Method to display book details
  public void DisplayBookInfo(){
    // Checking if this object is an instance of Book
    if (this is Book){
      Console.WriteLine($"Title: {Title}");
      Console.WriteLine($"Author: {Author}");
      Console.WriteLine($"ISBN: {ISBN}");
    }else{
      Console.WriteLine("not a valid Book object");
    }
  }
}
//program class for using
class Program{
  static void Main(string[] args){
    // Display library name using static 
    Book.DisplayLibraryName();
    Console.WriteLine();
    // Create book objects
    Book book1 = new Book("The Alchemist", "Paulo Coelho", "ISBN101");
    Book book2 = new Book("1984", "George Orwell", "ISBN102");
    // Display book details
    book1.DisplayBookInfo();
    Console.WriteLine();
    book2.DisplayBookInfo();
    Console.WriteLine();
  }
}
