public class Magzine : LibraryItem{
    public Magzine(string title) : base(title) { }
    public override int GetLoanDuration() => 6;
}
