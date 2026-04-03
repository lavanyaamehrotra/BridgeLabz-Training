using System;
public class InvoiceItem{
    public string taskName;
    public double amount;
    public InvoiceItem(string name, double amt){
        taskName = name;
        amount = amt;
    }
    public void DisplayItem(){
        Console.WriteLine(taskName + " - " + amount.ToString("F2"));
    }
}
