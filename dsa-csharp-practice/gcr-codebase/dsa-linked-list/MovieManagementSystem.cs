using System;
class MovieManagementSystem{
  // Node structure
  class Node{
  public string Title;
  public string Director;
  public int Year;
  public double Rating;
  public Node Next;
  public Node Prev;
  }
  static Node head = null;
  // Add at Beginning
  static void AddAtBeginning(string title, string director, int year, double rating){
    Node newNode = new Node();
    newNode.Title = title;
    newNode.Director = director;
    newNode.Year = year;
    newNode.Rating = rating;
    if (head != null){
      newNode.Next = head;
      head.Prev = newNode;
    }
    head = newNode;
    Console.WriteLine("Movie added at the begining");
    }
    // Add at End
  static void AddAtEnd(string title, string director, int year, double rating){
    Node newNode = new Node();
    newNode.Title = title;
    newNode.Director = director;
    newNode.Year = year;
    newNode.Rating = rating;
    if (head == null){
      head = newNode;
      Console.WriteLine("Movie added at the end");
      return;
    }
    Node temp = head;
    while (temp.Next != null)
    temp = temp.Next;
    temp.Next = newNode;
    newNode.Prev = temp;
    Console.WriteLine("Movie added at the end");
    }
    // Add at Specific Position
  static void AddAtPosition(int position, string title, string director, int year, double rating){
    if (position == 1){
      AddAtBeginning(title, director, year, rating);
      return;
    }
    Node temp = head;
    for (int i = 1; i < position - 1 && temp != null; i++)
      temp = temp.Next;
      if (temp == null){
        Console.WriteLine("Invalid position.");
        return;
      }
      Node newNode = new Node();
      newNode.Title = title;
      newNode.Director = director;
      newNode.Year = year;
      newNode.Rating = rating;
      newNode.Next = temp.Next;
      newNode.Prev = temp;
      if (temp.Next != null){
        temp.Next.Prev = newNode;
      }
      temp.Next = newNode;
      Console.WriteLine("Movie added at" + position);
    }
    // Remove by Movie Title
    static void RemoveByTitle(string title){
    if (head == null){
      Console.WriteLine("List is empty");
      return;
    }
    Node temp = head;
    while (temp != null && temp.Title != title){
      temp = temp.Next;
    }
    if (temp == null){
        Console.WriteLine("Movie not found.");
        return;
    }
    if (temp.Prev != null)
        temp.Prev.Next = temp.Next;
    else
        head = temp.Next;
    if (temp.Next != null)
        temp.Next.Prev = temp.Prev;
        Console.WriteLine("Movie removed successfully");
    }
    // Search by Director
    static void SearchByDirector(string director){
        Node temp = head;
        bool found = false;
        while (temp != null){
            if (temp.Director == director){
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
        Console.WriteLine("No movies found for this director");
    }
    // Search by Rating
    static void SearchByRating(double rating){
        Node temp = head;
        bool found = false;
        while (temp != null){
            if (temp.Rating == rating){
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }
         if (!found)
            Console.WriteLine("No movies found with this rating.");
    }
    // Update Rating by Title
    static void UpdateRating(string title, double newRating){
        Node temp = head;
        while (temp != null){
            if (temp.Title == title){
                temp.Rating = newRating;
                Console.WriteLine("Rating updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }

    // Display Forward
    static void DisplayForward(){
        if (head == null){
            Console.WriteLine("No movies");
            return;
        }
        Node temp = head;
        Console.WriteLine("\nMovies:");
        while (temp != null){
            DisplayMovie(temp);
            temp = temp.Next;
        }
    }
    // Display Reverse
    static void DisplayReverse(){
        if (head == null){
            Console.WriteLine("No movies");
            return;
        }

        Node temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        Console.WriteLine("\nMovies (Reverse):");
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Prev;
        }
    }

    static void DisplayMovie(Node a){
        Console.WriteLine("Title: " + a.Title +", Director: " + a.Director +", Year: " + a.Year +", Rating: " + a.Rating);
    }
        static void Main(){
        int choice;
        do{
            Console.WriteLine("\n--- Movie Management System ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Title");
            Console.WriteLine("5. Search by Director");
            Console.WriteLine("6. Search by Rating");
            Console.WriteLine("7. Update Rating");
            Console.WriteLine("8. Display Forward");
            Console.WriteLine("9. Display Reverse");
            Console.WriteLine("10. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    AddMovie(1);
                    break;
                case 2:
                    AddMovie(2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddMovie(3, pos);
                    break;
                case 4:
                    Console.Write("Enter movie title: ");
                    RemoveByTitle(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Enter director name: ");
                    SearchByDirector(Console.ReadLine());
                    break;
                case 6:
                    Console.Write("Enter rating: ");
                    SearchByRating(double.Parse(Console.ReadLine()));
                    break;
                case 7:
                    Console.Write("Enter movie title: ");
                    string t = Console.ReadLine();
                    Console.Write("Enter new rating: ");
                    UpdateRating(t, double.Parse(Console.ReadLine()));
                    break;
                case 8:
                    DisplayForward();
                    break;
                case 9:
                    DisplayReverse();
                    break;
            }

        } while (choice != 10);
    }

    static void AddMovie(int type, int position = 0){
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Rating: ");
        double rating = double.Parse(Console.ReadLine());
        if (type == 1)
            AddAtBeginning(title, director, year, rating);
        else if (type == 2)
            AddAtEnd(title, director, year, rating);
        else
            AddAtPosition(position, title, director, year, rating);
    }
}
