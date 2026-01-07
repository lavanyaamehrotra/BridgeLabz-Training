using System;
class Program{
    public static void Main(string[] args){
        Patient p1 = new InPatient("Lavanya Mehrotra", 5);
        Patient p2 = new OutPatient("Khushi Tiwari");
        System.Console.WriteLine(p1.CalculateBill());
        System.Console.WriteLine(p2.CalculateBill());
    }
}
