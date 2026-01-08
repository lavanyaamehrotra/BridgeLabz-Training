using System;
class InventoryManagementSystem{
    class Node{
    public int Id;
    public string Name;
    public int Quantity;
    public double Price;
    public Node Next;
    }
    static Node head = null;
    // Add at Beginning
    static void AddAtBeginning(int id, string name, int quantity, double price){
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Name = name;
        newNode.Quantity = quantity;
        newNode.Price = price;
        newNode.Next = head;
        head = newNode;
        onsole.WriteLine("Item added at beginning");
    }
    // Add at End
    static void AddAtEnd(int id, string name, int quantity, double price){
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Name = name;
        newNode.Quantity = quantity;
        newNode.Price = price;
        newNode.Next = null;
        if (head == null){
            head = newNode;
            Console.WriteLine("Item added at end");
            return;
        }
        Node temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newNode;
        Console.WriteLine("Item added at end");
    }
    // Add at Specific Position
    static void AddAtPosition(int position, int id, string name, int quantity, double price){
        if (position == 1){
            AddAtBeginning(id, name, quantity, price);
            return;
        }
        Node temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++){
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("Invalid position");
            return;
        }
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Name = name;
        newNode.Quantity = quantity;
        newNode.Price = price;
        newNode.Next = temp.Next;
        temp.Next = newNode;
        Console.WriteLine("Item added at  " + position);
    }
    // Remove by Item ID
    static void RemoveByItemID(int id){
        if (head == null){
            Console.WriteLine("Inventory is empty");
            return;
        }
        if (head.Id == id){
            head = head.Next;
            Console.WriteLine("Item removed");
            return;
        }
        Node temp = head;
        while (temp.Next != null && temp.Next.Id != id){
            temp = temp.Next;
        }
        if (temp.Next == null){
            Console.WriteLine("Item not found");
        }
        else{
            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed");
        }
    }
    // Update Quantity
    static void UpdateQuantity(int id, int newQuantity){
        Node temp = head;
        while (temp != null){
            if (temp.Id == id){
                temp.Quantity = newQuantity;
                Console.WriteLine("Quantity updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }
    // Search by Item ID
    static void SearchByID(int id){
        Node temp = head;
        while (temp != null){
            if (temp.Id == id){
                DisplayItem(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }
    // Search by Item Name
    static void SearchByName(string name){
        Node temp = head;
        bool found = false;
        while (temp != null){
            if (temp.Name == name){
                DisplayItem(temp);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("Item not found");
    }
    // Calculate Total Inventory Value
    static void CalculateTotalValue(){
        Node temp = head;
        double total = 0;
        while (temp != null){
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + total);
    }
    // Sort by Item Name or Price
    static void SortInventory(int choice, int order){
        if (head == null){
            return;
        }
        for (Node i = head; i.Next != null; i = i.Next){
            for (Node j = i.Next; j != null; j = j.Next){
                bool condition = false;
                if (choice == 1) {
                    if (order == 1 && string.Compare(i.Name, j.Name) > 0){
                        condition = true;
                    }
                    if (order == 2 && string.Compare(i.Name, j.Name) < 0){
                        condition = true;
                    }
                }
                else {
                    if (order == 1 && i.Price > j.Price){
                        condition = true;
                    }
                    if (order == 2 && i.Price < j.Price){
                        condition = true;
                    }
                }

                if (condition){
                    SwapData(i, j);
                }
            }
        }

        Console.WriteLine("Inventory sorted successfully.");
    }

    static void SwapData(Node a, Node b){
        int tempID = a.Id;
        string tempName = a.Name;
        int tempQuantty = a.Quantity;
        double tempPrice = a.Price;
        a.Id = b.Id;
        a.Name = b.Name;
        a.Quantity = b.Quantity;
        a.Price = b.Price;
        b.Id = tempID;
        b.Name = tempName;
        b.Quantity = tempQuantty;
        b.Price = tempPrice;
    }

    static void DisplayItem(Node i){
        Console.WriteLine("ID: " + i.Id +", Name: " + i.Name +", Quantity: " + i.Quantity +", Price: " + i.Price);
    }

    static void DisplayAll(){
        if (head == null){
            Console.WriteLine("Inventory is empty");
            return;
        }

        Node temp = head;
        Console.WriteLine("\nInventory Items:");
        while (temp != null){
            DisplayItem(temp);
            temp = temp.Next;
        }
    }
    static void Main(){
        int choice;
        do{
            Console.WriteLine("\n--- Inventory Management System ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Item ID");
            Console.WriteLine("5. Update Quantity");
            Console.WriteLine("6. Search by Item ID");
            Console.WriteLine("7. Search by Item Name");
            Console.WriteLine("8. Calculate Total Value");
            Console.WriteLine("9. Sort Inventory");
            Console.WriteLine("10. Display All");
            Console.WriteLine("11. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    AddItem(1);
                    break;
                case 2:
                    AddItem(2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddItem(3, pos);
                    break;
                case 4:
                    Console.Write("Enter Item ID: ");
                    RemoveByItemID(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    Console.Write("Enter Item ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter new quantity: ");
                    UpdateQuantity(id, int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    Console.Write("Enter Item ID: ");
                    SearchByID(int.Parse(Console.ReadLine()));
                    break;
                case 7:
                    Console.Write("Enter Item Name: ");
                    SearchByName(Console.ReadLine());
                    break;
                case 8:
                    CalculateTotalValue();
                    break;
                case 9:
                    Console.WriteLine("Sort by: 1.Name  2.Price");
                    int sortChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Order: 1.Ascending  2.Descending");
                    int order = int.Parse(Console.ReadLine());
                    SortInventory(sortChoice, order);
                    break;
                case 10:
                    DisplayAll();
                    break;
            }

        } while (choice != 11);
    }

    static void AddItem(int type, int position = 0){
        Console.Write("Item ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Item Name: ");
        string name = Console.ReadLine();
        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        if (type == 1){
            AddAtBeginning(id, name, quantity, price);
        }else if (type == 2){
            AddAtEnd(id, name, quantity, price);
        }else{
            AddAtPosition(position, id, name, quantity, price);
        }
    }
}
