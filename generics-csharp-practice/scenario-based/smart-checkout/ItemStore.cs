using System;
using System.Collections.Generic;
public class ItemStore{
    private Dictionary<string, (int price, int stock)> items =new Dictionary<string, (int, int)>();
    public void AddItem(){
        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Price: ");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Enter Stock: ");
        int stock = int.Parse(Console.ReadLine());
        items[name] = (price, stock);
        Console.WriteLine("Item added successfully!\n");
    }
    //availiable
    public bool IsAvailable(string item, int qty){
        return items.ContainsKey(item) && items[item].stock >= qty;
    }
    //get price
    public int GetPrice(string item){
        return items[item].price;
    }
    //update stock
    public void UpdateStock(string item, int qty){
        var data = items[item];
        items[item] = (data.price, data.stock - qty);
    }
    //show items
    public void ShowItems(){
        if (items.Count == 0){
            Console.WriteLine("No items available.\n");
            return;
        }
        Console.WriteLine("\n--- Available Items ---");
        foreach (var i in items){
            Console.WriteLine($"{i.Key} | Price: {i.Value.price} | Stock: {i.Value.stock}");
        }
        Console.WriteLine();
    }
    //item exists
    public bool ItemExists(string item){
        return items.ContainsKey(item);
    }
}
