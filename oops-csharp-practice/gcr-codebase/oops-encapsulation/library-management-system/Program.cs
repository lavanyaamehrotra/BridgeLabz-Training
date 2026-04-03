using System;
class Program{
    public static void Main(string[] args){
        LibraryItem b = new Book("C#");
        LibraryItem m = new Magzine("Technology");
        LibraryItem d = new Dvd("Tare Zammen Par");
        // Displaying loan durations 
        System.Console.WriteLine(b.GetLoanDuration());
        System.Console.WriteLine(m.GetLoanDuration());
        System.Console.WriteLine(d.GetLoanDuration());
    }
}
