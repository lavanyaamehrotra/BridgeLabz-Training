public class Book : LibraryItem{
    // Constructor with parameters 
    public Book(string title) : base(title) { }
    public override int GetLoanDuration() => 14;
}
