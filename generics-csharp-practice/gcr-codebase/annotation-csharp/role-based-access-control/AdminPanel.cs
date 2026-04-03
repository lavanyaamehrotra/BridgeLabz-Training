using System;
[RoleAllowed("ADMIN")]
public class AdminPanel{
    public void DeleteUser(){
        Console.WriteLine("User deleted successfully");
    }
}
