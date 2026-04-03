using System;
using System.Reflection;
class Program{
    static void Main(){
        string currentUserRole = "USER"; // change to ADMIN
        var attr = typeof(AdminPanel).GetCustomAttribute<RoleAllowedAttribute>();
        if (attr.Role == currentUserRole){
            new AdminPanel().DeleteUser();
        }else{
            Console.WriteLine("Access Denied!");
        }
    }
}
