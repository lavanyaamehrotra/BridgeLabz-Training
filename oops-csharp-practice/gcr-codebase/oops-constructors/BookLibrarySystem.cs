using System;
class BookLibrarySystem{
  public class Book{
    // Public Member
    public string ISBN;
    // Protected Member
    protected string title;
    // Private Member
    private string author;
    // Constructor
    public Book(string isbn, string title, string author){
      this.ISBN = isbn;
      this.title = title;
      this.author = author;
    }
    // Set Author
    public void SetAuthor(string author){
      this.author = author;
    }
    // Get Author
    public string GetAuthor(){
      return author;
    }
    // Display Book Details
    public void DisplayBooks(){
      Console.WriteLine("ISBN: " + ISBN);
      Console.WriteLine("Title: " + title);
      Console.WriteLine("Author: " + author);
    }
  }
  public class EBook : Book{
    public double fileSize; 
    // Constructor
    public EBook(string isbn, string title, string author, double fileSize): base(isbn, title, author){
      this.fileSize = fileSize;
    }
    // Display EBook Details
    public void DisplayEBooks(){
      Console.WriteLine("\nE-Book Details");
      // Accessing PUBLIC member
      Console.WriteLine("ISBN: " + ISBN);
      // Accessing PROTECTED member
      Console.WriteLine("Title: " + title);
      Console.WriteLine("File Size: " + fileSize + " MB");
    }
  }
  public static void Main(string[] args){
    Book b1 = new Book("123456789", "Pyhton", "King");
    b1.DisplayBooks();
    // Update Author
    Console.WriteLine("\nUpdating Author...");
    b1.SetAuthor("Rs Agarawal");
    Console.WriteLine("Updated Author: " + b1.GetAuthor());
    // Create an EBook object
    EBook eb = new EBook("987654321", "C#", "Madan", 2.5);
    eb.DisplayEBooks();
  }
}
