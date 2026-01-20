using System;
// electronics class implements warehouseItem class 
public class Electronics : WarehouseItem{
    public string Brand { get; set; }
    public Electronics(int id, string name, int quantity, string brand): base(id, name, quantity){
        Brand = brand;
    }
    //display
    public override void Display(){
        Console.WriteLine($"[Electronics] ID: {Id}, Name: {Name}, Brand: {Brand}, Qty: {Quantity}");
    }
}
