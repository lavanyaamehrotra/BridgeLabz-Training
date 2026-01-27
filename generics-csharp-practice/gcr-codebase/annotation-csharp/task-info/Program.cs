using System.Reflection;
class Program{
    static void Main(){
        MethodInfo method =typeof(TaskManager).GetMethod("DeploySystem");
        TaskInfoAttribute attr =method.GetCustomAttribute<TaskInfoAttribute>();
        Console.WriteLine($"Priority: {attr.Priority}");
        Console.WriteLine($"Assigned To: {attr.AssignedTo}");
    }
}
