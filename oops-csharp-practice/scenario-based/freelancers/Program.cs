using System;

class Program{
    static void Main(string[] args){
        InvoiceGenerator generator = new InvoiceGenerator();
        Console.WriteLine("=== SIMPLE INVOICE GENERATOR ===\n");
        Console.WriteLine("Enter items in format:");
        Console.WriteLine("Task - Amount, Task - Amount");
        Console.WriteLine("Example: Design - 3000, Development - 5000\n");
        Console.Write("Enter invoice items: ");
        string input = Console.ReadLine();
        Console.Write("Enter client name: ");
        string client = Console.ReadLine();
        Console.Write("Enter tax rate: ");
        string taxInput = Console.ReadLine();
        double taxRate = 18;
        if (!string.IsNullOrWhiteSpace(taxInput)){
            double.TryParse(taxInput, out taxRate);
        }
        Console.WriteLine("\n=== GENERATED INVOICE ===\n");
        generator.GenerateInvoice(input, client, taxRate);
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}
