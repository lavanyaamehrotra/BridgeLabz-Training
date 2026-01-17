using System;
public class Manager{
    //function to add user 
    public User[] AddUsers(int count){
        User[] users = new User[count];
        for (int i = 0; i < count; i++){
            Console.Write($"Enter steps for User {i + 1}: ");
            int steps = Convert.ToInt32(Console.ReadLine());
            users[i] = new User(steps);
        }
        return users;
    }
    //function to display user 
    public void DisplayUsers(User[] users){
        if (users == null){
            Console.WriteLine("please add users first.");
            return;
        }
        Console.WriteLine("\n--- Daily Step Count Ranking ---");
        for (int i = 0; i < users.Length; i++){
            Console.WriteLine($"Rank {i + 1}: {users[i].Steps} steps");
        }
    }
}
