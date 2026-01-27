using System;
using System.Reflection;
class Program{
    static void Main(){
        foreach (MethodInfo method in typeof(Service).GetMethods()){
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null){
                Console.WriteLine($"{method.Name} - Importance: {attr.Level}");
            }
        }
    }
}
