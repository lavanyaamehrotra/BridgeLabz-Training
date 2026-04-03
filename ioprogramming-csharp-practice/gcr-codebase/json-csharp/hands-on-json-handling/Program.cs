using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        HandsOnJsonService service = new HandsOnJsonService();
        Console.WriteLine("1. Keys and Values:");
        service.PrintKeysAndValues("{ 'name':'Lavanya', 'age':21, 'city':'Prayagraj' }");
        Console.WriteLine("\n2. List to JSON Array:");
        List<User> users = new List<User>{
            new User { Name="Lavanya", Age=21, Email="amit@gmail.com" },
            new User { Name="Khushi", Age=22, Email="neha@gmail.com" }
        };
        Console.WriteLine(service.ConvertListToJsonArray(users));
        Console.WriteLine("\n3. Users Age > 25:");
        var filtered = service.FilterUsersAbove25(@"[
            { 'name':'Lavanya', 'age':21 },
            { 'name':'Khushi', 'age':22 }
        ]");
        foreach (var item in filtered)
            Console.WriteLine(item);
        Console.WriteLine("\n4️. Email Validation:");
        Console.WriteLine(service.ValidateEmail("{ 'email':'test@gmail.com' }"));
        Console.WriteLine("\n5️.Merge JSON:");
        Console.WriteLine(service.MergeJson(
            "{ 'name':'Lavanya' }",
            "{ 'email':'lavanya@gmail.com' }"
        ));
        Console.WriteLine("\n6. JSON to XML:");
        Console.WriteLine(service.ConvertJsonToXml(
            "{ 'user': { 'name':'Lavanya' } }"
        ).OuterXml);
        Console.WriteLine("\n7️. CSV to JSON:");
        string[] csv =
        {
            "name,age,email",
            "Amit,21,lavanya@gmail.com",
            "Neha,22,khushi@gmail.com"
        };
        Console.WriteLine(service.ConvertCsvToJson(csv));
        Console.WriteLine("\n8️. JSON from Database:");
        Console.WriteLine(service.GenerateJsonFromDatabase());
    }
}
