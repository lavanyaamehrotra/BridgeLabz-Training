using System;
using System.Reflection;
class Program{
    static void Main(){
        var todos = typeof(ProjectModule).GetMethod("BuildModule").GetCustomAttributes<TodoAttribute>();
        foreach (var todo in todos){
            Console.WriteLine($"{todo.Task} | {todo.AssignedTo} | {todo.Priority}");
        }
    }
}
