using System;
public class InvoiceGenerator{
    private InvoiceParser parser = new InvoiceParser();
    //method to generate the invoice 
    public void GenerateInvoice(string invoiceInput, string clientName = "", double taxRate = 18.0){
        string[] tasks = parser.ParseInvoice(invoiceInput);
        double subtotal = 0;
        Console.Clear();
        Console.WriteLine("INVOICE");
        Console.WriteLine($"Invoice No: {parser.GenerateInvoiceNumber()}");
        Console.WriteLine($"Date: {DateTime.Now:dd-MMM-yyyy HH:mm:ss}");
        if (!string.IsNullOrEmpty(clientName)){
            Console.WriteLine($"Client: {clientName}");
        }
        Console.WriteLine("Items:");
        for (int i = 0; i < tasks.Length; i++){
            string name = parser.ExtractTaskName(tasks[i]);
            double amount = parser.ExtractAmount(tasks[i]);
            Console.WriteLine($"{i + 1}. {name} - {parser.FormatCurrency(amount)}");
            subtotal += amount;
        }
        double tax = parser.CalculateTax(subtotal, taxRate);
        double total = subtotal + tax;
        Console.WriteLine($"Subtotal : {parser.FormatCurrency(subtotal)}");
        Console.WriteLine($"Tax ({taxRate}%) : {parser.FormatCurrency(tax)}");
        Console.WriteLine($"Total    : {parser.FormatCurrency(total)}");
        Console.WriteLine("Thank you for your business");
    }
}
