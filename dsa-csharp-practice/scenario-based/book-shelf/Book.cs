// Represents a single book
class Book{
    public string Title;
    public string Author;
    // Constructor 
    public Book(string title, string author){
        Title = title;
        Author = author;
    }
    public string Key(){
        return Title + "-" + Author;
    }
}
