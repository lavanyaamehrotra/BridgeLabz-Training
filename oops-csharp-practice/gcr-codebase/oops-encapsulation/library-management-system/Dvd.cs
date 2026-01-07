public class Dvd : LibraryItem{
    public Dvd(string title) : base(title) { }
    public override int GetLoanDuration() => 3;
}
