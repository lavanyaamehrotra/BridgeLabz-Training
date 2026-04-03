// Library class
class Library{
    private CustomHashMap catalog = new CustomHashMap();

    // Return book (Insert)
    public void AddBook(string genre, string title, string author){
        Book book = new Book(title, author);
        catalog.GetOrCreate(genre).Add(book);
        Console.WriteLine("Book added successfully.");
    }
    // Borrow book (Delete)
    public void BorrowBook(string genre, string title, string author){
        string key = title + "-" + author;
        catalog.GetOrCreate(genre).Remove(key);
        Console.WriteLine("Book borrowed successfully.");
    }
    // Display library catalog
    public void DisplayBooks(){
        Console.WriteLine("\nLibrary books:");
        catalog.DisplayAll();
    }
}
