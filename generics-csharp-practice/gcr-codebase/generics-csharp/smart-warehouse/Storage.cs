using System;
using System.Collections.Generic;
public class Storage<T> : IReadOnlyStorage<T> where T : WarehouseItem{
    private List<T> items = new List<T>();
    // Add item
    public void AddItem(T item){
        items.Add(item);
    }
    // Remove item by ID
    public bool RemoveItem(int id){
        var item = items.Find(i => i.Id == id);
        if (item != null){
            items.Remove(item);
            return true;
        }
        return false;
    }
    // Search item by ID (Linear Search - DSA)
    public T GetItemById(int id){
        return items.Find(i => i.Id == id);
    }
    // Display all items
    public void DisplayAllItems() {
        foreach (var item in items)
            item.Display();
    }
    // For variance demo
    public IEnumerable<T> GetAllItems(){
        return items;
    }
}
