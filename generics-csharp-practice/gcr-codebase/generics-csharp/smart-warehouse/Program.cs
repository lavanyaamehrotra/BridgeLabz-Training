using System;
class Program{
    public static void Main(string[] args){
        Console.WriteLine("=== SMART WAREHOUSE MANAGEMENT SYSTEM ===\n");
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        // --------- ELECTRONICS INPUT ---------
        Console.Write("Enter number of Electronics items: ");
        int eCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < eCount; i++){
            Console.WriteLine($"\nEnter details for Electronics Item {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            electronicsStorage.AddItem(new Electronics(id, name, qty, brand));
        }
        // --------- GROCERIES INPUT ---------
        Console.Write("\nEnter number of Grocery items: ");
        int gCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < gCount; i++){
            Console.WriteLine($"\nEnter details for Grocery Item {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());
            Console.Write("Expiry Date (yyyy-mm-dd): ");
            DateTime expiry = DateTime.Parse(Console.ReadLine());
            groceriesStorage.AddItem(new Groceries(id, name, qty, expiry));
        }
        // --------- FURNITURE INPUT ---------
        Console.Write("\nEnter number of Furniture items: ");
        int fCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < fCount; i++){
            Console.WriteLine($"\nEnter details for Furniture Item {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());
            Console.Write("Material: ");
            string material = Console.ReadLine();
            furnitureStorage.AddItem(new Furniture(id, name, qty, material));
        }
        // --------- DISPLAY ALL ITEMS ---------
        Console.WriteLine("\n---- Electronics ----");
        electronicsStorage.DisplayAllItems();
        Console.WriteLine("\n---- Groceries ----");
        groceriesStorage.DisplayAllItems();
        Console.WriteLine("\n---- Furniture ----");
        furnitureStorage.DisplayAllItems();
        // --------- SEARCH (DSA) ---------
        Console.Write("\nEnter Electronics ID to search: ");
        int searchId = int.Parse(Console.ReadLine());
        var foundItem = electronicsStorage.GetItemById(searchId);
        if (foundItem != null){
            Console.WriteLine("\nItem Found:");
            foundItem.Display();
        }
        else{
            Console.WriteLine("\nItem not found!");
        }
        // --------- VARIANCE DEMO ---------
        Console.WriteLine("\n===========Variance Demo=============");
        IReadOnlyStorage<WarehouseItem> readOnlyView = electronicsStorage;
        foreach (var item in readOnlyView.GetAllItems()){
            item.Display();
        }
        Console.ReadLine();
    }
}
