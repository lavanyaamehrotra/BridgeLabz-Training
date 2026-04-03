using System;
class LibraryBook{
  public string Title;
  public string Author;
  public double Price;
  public bool IsAvailable;
  //Parameterized constructor
  public LibraryBook(string title,string author,double price,bool isAvailable){
    Tiltle=title;
    Author=author;
    Price=price;
    IsAvailable=isAvailable;
  }
  //Method to borrow book
  public void BorrowBook(){
    if (IsAvailable){
      Console.WriteLine($"You borrowed:{Title}");
      IsAvailable=false;
    }
    else{
      Console.WriteLine($"Sorry, {Title} is already borrowed");
    }
  }
  public void Display(){
    Console.WriteLine($"Title: {Title}");
    Console.WriteLine($"Author: {Author}");
    Console.WriteLine($"Price: {Price}");
    Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
  }
}
class Program{
  static void Main(string[] args){
    LibraryBook book1 = new LibraryBook("C#", "Microsoft", 399, true);
    Console.WriteLine("Book Details:");
    book1.Display();
    Console.WriteLine();
    book1.BorrowBook();
    Console.WriteLine();
    book1.BorrowBook();
  }
}