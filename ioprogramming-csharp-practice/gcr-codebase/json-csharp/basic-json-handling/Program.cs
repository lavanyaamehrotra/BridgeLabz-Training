using System;
using System.Collections.Generic;
class Program{
    static void Main(string[] args){
        JsonService service = new JsonService();
        Console.WriteLine("Student JSON:\n" + service.CreateStudentJSON());
        Console.WriteLine("\nCar JSON:\n" + service.ConvertCarToJSON());
        Console.WriteLine("\nExtracted Fields:");
        service.ExtractFields("{ 'name':'Khushi', 'email':'khushi@gmail.com', 'age':22 }");
        Console.WriteLine("\nMerged JSON:");
        Console.WriteLine(service.MergeJSON(
            "{ 'name':'Lavanya', 'age':21 }",
            "{ 'email':'lavanya@gmail.com' }"
        ));
        string schema = @"{
            'type':'object',
            'properties':{
                'email':{
                    'type':'string',
                    'pattern':'^[^@]+@[^@]+\\.[^@]+$'
                }
            },
            'required':['email']
        }";
        Console.WriteLine("\nJSON Valid: " +
            service.ValidateJSON("{ 'email':'test@gmail.com' }", schema));
        List<Student> students = new List<Student>{
            new Student { Name="Khushi", Age=23 },
            new Student { Name="Neha", Age=23 }
        };
        Console.WriteLine("\nJSON Array:\n" +
            service.ConvertListToJSONArray(students));
        Console.WriteLine("\nAge > 25:");
        var filtered = service.FilterAge(@"[
            { 'name':'Khushi', 'age':23 },
            { 'name':'Neha', 'age':23 }
        ]");
        foreach (var item in filtered){
            Console.WriteLine(item);
        }
    }
}
