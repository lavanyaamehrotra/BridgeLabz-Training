using System;
public abstract class WarehouseItem{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }

    // constructor 
    protected WarehouseItem(int id, string name, int quantity)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
    }

    public abstract void Display();
}
