using System;
public class InvoiceTester{
    private InvoiceParser parser = new InvoiceParser();
    private InvoiceGenerator generator = new InvoiceGenerator();
    public void TestParsing(){
        Console.WriteLine("=== TEST PARSING ===\n");
        string input = "Design - 3000, Development - 5000, Testing - 2000";
        string[] tasks = parser.ParseInvoice(input);
        for (int i = 0; i < tasks.Length; i++){
            string name = parser.ExtractTaskName(tasks[i]);
            double amount = parser.ExtractAmount(tasks[i]);
            Console.WriteLine($"{i + 1}. {name} = {amount}");
        }
        double total = parser.GetTotalAmount(tasks);
        Console.WriteLine($"\nTotal = {total}");
    }

    public void TestInvoice(){
        Console.WriteLine("\n=== TEST INVOICE GENERATION ===\n");
        string input = "Design - 3000, Development - 5000, Testing - 2000";
        generator.GenerateInvoice(input, "Sample Client", 18);
    }
    public void RunTests(){
        TestParsing();
        TestInvoice();
    }
}
