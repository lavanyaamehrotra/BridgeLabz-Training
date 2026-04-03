public abstract class LibraryItem{
    protected string title;
    // Constructor with parameter 
    protected LibraryItem(string title){
        this.title = title;
    }
    public abstract int GetLoanDuration();
}
