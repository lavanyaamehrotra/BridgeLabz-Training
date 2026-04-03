using System;
public class Groceries : WarehouseItem{
    public DateTime ExpiryDate { get; set; }
    public Groceries(int id, string name, int quantity, DateTime expiry): base(id, name, quantity){
        ExpiryDate = expiry;
    }
    //display
    public override void Display(){
        Console.WriteLine($"[Groceries] ID: {Id}, Name: {Name}, Expiry: {ExpiryDate.ToShortDateString()}, Qty: {Quantity}");
    }
}
