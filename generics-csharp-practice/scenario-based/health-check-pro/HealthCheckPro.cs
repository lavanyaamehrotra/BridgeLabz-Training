using System;
using System.Linq;
using System.Reflection;
public class HealthCheckPro{
    Assembly assembly = Assembly.GetExecutingAssembly();
    //  validate annotations
    public void ValidateAPIs(){
        Console.WriteLine("\nAPI Validation Report\n");
        var controllers = assembly.GetTypes().Where(t => t.IsClass && t.Name.EndsWith("Controller"));
        foreach (var controller in controllers){
            Console.WriteLine("Controller: " + controller.Name);
            var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods){
                var publicApi = method.GetCustomAttribute<PublicAPIAttribute>();
                if (publicApi == null){
                    Console.WriteLine(method.Name + " → Missing PublicAPI");
                }else{
                    Console.WriteLine(method.Name + " → OK");
                }
            }
            Console.WriteLine();
        }
    }
    // Generate simple API documenation
    public void GenerateDocs(){
        Console.WriteLine("\nAPI Documentation\n");
        var controllers = assembly.GetTypes().Where(t => t.IsClass && t.Name.EndsWith("Controller"));
        foreach (var controller in controllers){
            Console.WriteLine("Controller: " + controller.Name);
            var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods){
                var publicApi = method.GetCustomAttribute<PublicAPIAttribute>();
                var auth = method.GetCustomAttribute<RequiresAuthAttribute>() != null;
                if (publicApi != null){
                    Console.WriteLine(" • Method: " + method.Name);
                    Console.WriteLine("   Description: " + publicApi.Description);
                    Console.WriteLine("   Auth Required: " + auth);
                }
            }
            Console.WriteLine();
        }
    }
}
