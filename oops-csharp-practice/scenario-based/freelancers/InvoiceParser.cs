using System;

public class InvoiceParser{
    // Split input into tasks
    public string[] ParseInvoice(string input){
        if (string.IsNullOrWhiteSpace(input)){
            return new string[0];
        }
        string[] tasks = input.Split(',');
        for (int i = 0; i < tasks.Length; i++){
            tasks[i] = tasks[i].Trim();
        }

        return tasks;
    }
    // Get task name 
    public string ExtractTaskName(string task){
        if (string.IsNullOrWhiteSpace(task)){
            return "";
        }
         int dash = task.IndexOf('-');
         if (dash == -1){
            return task.Trim();
        }
        return task.Substring(0, dash).Trim();
    }

    // Extract amount
    public double ExtractAmount(string task){
        if (string.IsNullOrWhiteSpace(task)){
            return 0;
        }
        int dash = task.IndexOf('-');
        string value = (dash == -1)? task: task.Substring(dash + 1);
        value = value.Trim();
        double amount;
        return double.TryParse(value, out amount) ? amount : 0;
    }

    // Sum all amounts
    public double GetTotalAmount(string[] tasks){
        double total = 0;
        for (int i = 0; i < tasks.Length; i++){
            total += ExtractAmount(tasks[i]);
        }
        return total;
    }

    // Tax
    public double CalculateTax(double subtotal, double rate = 18.0){
        return subtotal * rate / 100.0;
    }

    // Final total
    public double CalculateFinalTotal(double subtotal, double rate = 18.0){
        return subtotal + CalculateTax(subtotal, rate);
    }

    // Simple currency format
    public string FormatCurrency(double amount){
        return amount.ToString("F2");
    }

    // Simple invoice number
    public string GenerateInvoiceNumber(){
        return "INV-" + DateTime.Now.ToString("yyyyMMddHHmmss");
    }
}
