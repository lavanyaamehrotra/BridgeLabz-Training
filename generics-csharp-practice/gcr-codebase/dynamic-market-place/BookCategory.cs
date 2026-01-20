using System;
public class BookCategory : ProductCategory{
    public string Genre { get; set; }
    public BookCategory(string genre): base("Book"){
        Genre = genre;
    }
    public override void DisplayCategory() {
        Console.WriteLine($"Category: Book || Genre: {Genre}");
    }
}
