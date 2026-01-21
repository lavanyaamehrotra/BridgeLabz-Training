using System;
class Program{
    static void Main(){
        ItemStore store = new ItemStore();
        CheckoutQueue checkout = new CheckoutQueue(store);
        int choice;
        do{
            Console.WriteLine("==== SmartCheckout System ====");
            Console.WriteLine("1. Add Item to Store");
            Console.WriteLine("2. Show Store Items");
            Console.WriteLine("3. Add Customer to Queue");
            Console.WriteLine("4. Process Billing");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    store.AddItem();
                    break;
                case 2:
                    store.ShowItems();
                    break;
                case 3:
                    checkout.AddCustomer();
                    break;
                case 4:
                    checkout.ProcessBilling();
                    break;
                case 5:
                    Console.WriteLine("System closed.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 5);
    }
}
