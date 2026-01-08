using System;
class SocialMediaConnections{
    // Node structure
    class Node{
        public int Id;
        public string Name;
        public int Age;
        public int[] Friends = new int[10];
        public int FriendsCounts = 0;
        public Node Next;
    }
    static Node head = null;
    // Add a new user
    static void AddUser(int id, string name, int age){
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Name = name;
        newNode.Age = age;
        newNode.Next = head;
        head = newNode;
        Console.WriteLine("User added successfully");
    }

    // Find user by ID
    static Node FindUserByID(int id){
        Node temp = head;
        while (temp != null){
            if (temp.Id == id){
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }
    // Add friend connection
    static void AddFriend(int id1, int id2){
        Node user1 = FindUserByID(id1);
        Node user2 = FindUserByID(id2);
        if (user1 == null || user2 == null){
            Console.WriteLine("not found.");
            return;
        }
        user1.Friends[user1.FriendsCounts++] = id2;
        user2.Friends[user2.FriendsCounts++] = id1;
        Console.WriteLine("Friend connection added");
    }
    // Remove friend connection
    static void RemoveFriendConnection(int id1, int id2){
        Node user1 = FindUserByID(id1);
        Node user2 = FindUserByID(id2);
        if (user1 == null || user2 == null){
            Console.WriteLine("not found.");
            return;
        }
        RemoveFriend(user1, id2);
        RemoveFriend(user2, id1);
        Console.WriteLine("Friend connection removed");
    }

    static void RemoveFriend(Node user, int friendID){
        for (int i = 0; i < user.FriendsCounts; i++){
            if (user.Friends[i] == friendID){
                for (int j = i; j < user.FriendsCounts - 1; j++){
                    user.Friends[j] = user.Friends[j + 1];
                }
                user.FriendsCounts--;
                return;
            }
        }
    }
    // Find mutual friends
    static void FindMutualFriends(int id1, int id2){
        Node user1 = FindUserByID(id1);
        Node user2 = FindUserByID(id2);
        if (user1 == null || user2 == null){
            Console.WriteLine("not found.");
            return;
        }
        Console.WriteLine("Mutual Friends:");
        bool found = false;
        for (int i = 0; i < user1.FriendsCounts; i++){
            for (int j = 0; j < user2.FriendsCounts; j++){
                if (user1.Friends[i] == user2.Friends[j]){
                    Console.WriteLine("Friend ID: " + user1.Friends[i]);
                    found = true;
                }
            }
        }
        if (!found)
            Console.WriteLine("No mutual friends.");
    }

    // Display all friends of a user
    static void DisplayFriends(int id){
        Node user = FindUserByID(id);
        if (user == null){
            Console.WriteLine("not found.");
            return;
        }
        Console.WriteLine("Friends of " + user.Name + ":");
        for (int i = 0; i < user.FriendsCounts; i++){
            Console.WriteLine("Friend ID: " + user.Friends[i]);
        }
        if (user.FriendsCounts == 0){
            Console.WriteLine("No friends");
        }
    }
    // Search user by Name
    static void SearchByName(string name){
        Node temp = head;
        bool found = false;
        while (temp != null){
            if (temp.Name == name){
                DisplayUser(temp);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("User not found.");
    }

    // Search user by ID
    static void SearchByID(int id){
        Node user = FindUserByID(id);
        if (user != null){
            DisplayUser(user);
        }else{
            Console.WriteLine("User not found.");
        }
    }
    // Count friends of each user
    static void CountFriends(){
        Node temp = head;
        while (temp != null){
            Console.WriteLine("User: " + temp.Name +", Friends Count: " + temp.FriendsCounts);
            temp = temp.Next;
        }
    }

    static void DisplayUser(Node u){
        Console.WriteLine("ID: " + u.Id +", Name: " + u.Name +", Age: " + u.Age);
    }
    static void Main(){
        int choice;
        do{
            Console.WriteLine("\n--- Social Media Friend Connections ---");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Add Friend Connection");
            Console.WriteLine("3. Remove Friend Connection");
            Console.WriteLine("4. Find Mutual Friends");
            Console.WriteLine("5. Display User Friends");
            Console.WriteLine("6. Search by Name");
            Console.WriteLine("7. Search by User ID");
            Console.WriteLine("8. Count Friends for Each User");
            Console.WriteLine("9. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("User ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    AddUser(id, name, age);
                    break;
                case 2:
                    Console.Write("User ID 1: ");
                    int u1 = int.Parse(Console.ReadLine());
                    Console.Write("User ID 2: ");
                    int u2 = int.Parse(Console.ReadLine());
                    AddFriend(u1, u2);
                    break;
                case 3:
                    Console.Write("User ID 1: ");
                    int r1 = int.Parse(Console.ReadLine());
                    Console.Write("User ID 2: ");
                    int r2 = int.Parse(Console.ReadLine());
                    RemoveFriendConnection(r1, r2);
                    break;
                case 4:
                    Console.Write("User ID 1: ");
                    int m1 = int.Parse(Console.ReadLine());
                    Console.Write("User ID 2: ");
                    int m2 = int.Parse(Console.ReadLine());
                    FindMutualFriends(m1, m2);
                    break;
                case 5:
                    Console.Write("User ID: ");
                    DisplayFriends(int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    Console.Write("Enter Name: ");
                    SearchByName(Console.ReadLine());
                    break;
                case 7:
                    Console.Write("Enter User ID: ");
                    SearchByID(int.Parse(Console.ReadLine()));
                    break;
                case 8:
                    CountFriends();
                    break;
            }

        } while (choice != 9);
    }
}
