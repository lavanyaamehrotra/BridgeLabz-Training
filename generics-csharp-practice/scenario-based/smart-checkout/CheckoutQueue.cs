using System;
using System.Collections.Generic;
public class CheckoutQueue{
    private Queue<Customer> queue = new Queue<Customer>();
    private ItemStore store;
    public CheckoutQueue(ItemStore store){
        this.store = store;
    }
    //add customer
    public void AddCustomer(){
        Console.Write("Enter Customer Name: ");
        Customer customer = new Customer(Console.ReadLine());
        Console.Write("Enter number of items: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++){
            Console.Write("Item Name: ");
            string item = Console.ReadLine();
            if (!store.ItemExists(item)){
                Console.WriteLine("Item not found!");
                i--;
                continue;
            }
            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());
            customer.AddItem(item, qty);
        }
        queue.Enqueue(customer);
        Console.WriteLine("Customer added to checkout queue.\n");
    }
    //process billing
    public void ProcessBilling(){
        if (queue.Count == 0){
            Console.WriteLine("No customers in queue.\n");
            return;
        }
        Customer customer = queue.Dequeue();
        int total = 0;
        Console.WriteLine($"\n--- Billing for {customer.Name} ---");
        foreach (var item in customer.Cart){
            if (store.IsAvailable(item.Key, item.Value)){
                int cost = store.GetPrice(item.Key) * item.Value;
                total += cost;
                store.UpdateStock(item.Key, item.Value);
                Console.WriteLine($"{item.Key} x {item.Value} = {cost}");
            }else{
                Console.WriteLine($"{item.Key} - Insufficient stock");
            }
        }
        Console.WriteLine($"Total Amount: {total}\n");
    }
}
