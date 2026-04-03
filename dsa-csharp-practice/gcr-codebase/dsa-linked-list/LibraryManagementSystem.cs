using System;
class LibraryManagementSystem{
    // Node structure
    class Node{
        public int Id;
        public string Title;
        public string Author;
        public string Genre;
        public bool Available;
        public Node Next;
        public Node Prev;
    }
    static Node head = null;
    // Add at Beginning
    static void AddAtBeginning(int id, string title, string author, string genre, bool available){
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Title = title;
        newNode.Author = author;
        newNode.Genre = genre;
        newNode.Available = available;
        if (head != null){
            newNode.Next = head;
            head.Prev = newNode;
        }
        head = newNode;
        Console.WriteLine("Book added at beginning");
    }
    // Add at End
    static void AddAtEnd(int id, string title, string author, string genre, bool available){
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Title = title;
        newNode.Author = author;
        newNode.Genre = genre;
        newNode.Available = available;
        if (head == null){
            head = newNode;
            Console.WriteLine("Book added at end.");
            return;
        }
        Node temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newNode;
        newNode.Prev = temp;
        Console.WriteLine("Book added at end.");
    }
    // Add at Specific Position
    static void AddAtPosition(int position, int id, string title, string author, string genre, bool available){
        if (position == 1){
            AddAtBeginning(id, title, author, genre, available);
            return;
        }

        Node temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++){
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("Invalid position.");
            return;
        }
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Title = title;
        newNode.Author = author;
        newNode.Genre = genre;
        newNode.Available = available;
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        if (temp.Next != null){
            temp.Next.Prev = newNode;
        }
        temp.Next = newNode;

        Console.WriteLine("Book added at position " + position);
    }
    // Remove by Book ID
    static void RemoveByBookID(int id){
        if (head == null){
            Console.WriteLine("Library is empty.");
            return;
        }

        Node temp = head;
        while (temp != null && temp.Id != id){
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("Book not found.");
            return;
        }
        if (temp.Prev != null){
            temp.Prev.Next = temp.Next;
        }else{
            head = temp.Next;
        }
        if (temp.Next != null){
            temp.Next.Prev = temp.Prev;
        }
        Console.WriteLine("Book removed successfully");
    }
    // Search by Title
    static void SearchByTitle(string title){
        Node temp = head;
        bool found = false;
        while (temp != null){
            if (temp.Title == title){
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found.");
    }
    // Search by Author
    static void SearchByAuthor(string author){
        Node temp = head;
        bool found = false;
        while (temp != null){
            if (temp.Author == author){
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found){
            Console.WriteLine("Book not found.");
        }
    }
    // Update Availability Status
    static void UpdateAvailability(int id, bool status){
        Node temp = head;
        while (temp != null){
            if (temp.Id == id){
                temp.Available = status;
                Console.WriteLine("Availability updated.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }
    // Display Forward
    static void DisplayForward(){
        if (head == null){
            Console.WriteLine("Library is empty.");
            return;
        }
        Node temp = head;
        Console.WriteLine("\nBooks (Forward):");
        while (temp != null){
            DisplayBook(temp);
            temp = temp.Next;
        }
    }
    // Display Reverse
    static void DisplayReverse(){
        if (head == null){
            Console.WriteLine("Library is empty.");
            return;
        }
        Node temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        Console.WriteLine("\nBooks (Reverse):");
        while (temp != null){
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }
    // Count Total Books
    static void CountBooks(){
        int count = 0;
        Node temp = head;
        while (temp != null){
            count++;
            temp = temp.Next;
        }

        Console.WriteLine("Total number of books: " + count);
    }
    static void DisplayBook(Node b){
        Console.WriteLine("ID: " + b.Id +", Title: " + b.Title +", Author: " + b.Author +", Genre: " + b.Genre +", Available: " + (b.Available ? "Yes" : "No"));
    }
    static void Main(){
        int choice;
        do{
            Console.WriteLine("\n--- Library Management System ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Book ID");
            Console.WriteLine("5. Search by Title");
            Console.WriteLine("6. Search by Author");
            Console.WriteLine("7. Update Availability");
            Console.WriteLine("8. Display Forward");
            Console.WriteLine("9. Display Reverse");
            Console.WriteLine("10. Count Books");
            Console.WriteLine("11. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    AddBook(1);
                    break;
                case 2:
                    AddBook(2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddBook(3, pos);
                    break;
                case 4:
                    Console.Write("Enter Book ID: ");
                    RemoveByBookID(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    Console.Write("Enter Title: ");
                    SearchByTitle(Console.ReadLine());
                    break;
                case 6:
                    Console.Write("Enter Author: ");
                    SearchByAuthor(Console.ReadLine());
                    break;
                case 7:
                    Console.Write("Enter Book ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Available (true/false): ");
                    UpdateAvailability(id, bool.Parse(Console.ReadLine()));
                    break;
                case 8:
                    DisplayForward();
                    break;
                case 9:
                    DisplayReverse();
                    break;
                case 10:
                    CountBooks();
                    break;
            }

        } while (choice != 11);
    }
    static void AddBook(int type, int position = 0){
        Console.Write("Book ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Genre: ");
        string genre = Console.ReadLine();
        Console.Write("Available (true/false): ");
        bool available = bool.Parse(Console.ReadLine());
        if (type == 1){
            AddAtBeginning(id, title, author, genre, available);
        }else if (type == 2){
            AddAtEnd(id, title, author, genre, available);
        }else{
            AddAtPosition(position, id, title, author, genre, available);
        }
    }
}
