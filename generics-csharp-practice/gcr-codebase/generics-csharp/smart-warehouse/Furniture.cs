using System;
public class Furniture : WarehouseItem{
    public string Material { get; set; }
    public Furniture(int id, string name, int quantity, string material): base(id, name, quantity){
        Material = material;
    }
    //display
    public override void Display(){
        Console.WriteLine($"[Furniture] ID: {Id}, Name: {Name}, Material: {Material}, Qty: {Quantity}");
    }
}
