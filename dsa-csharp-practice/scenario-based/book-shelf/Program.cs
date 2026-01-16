
class Program{
    static void Main(){
        Library library = new Library();
        int choice;
        do{
            Console.WriteLine("\n--- Library Menu ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine()!);
            if (choice == 1){
                Console.Write("Genre: ");
                string genre = Console.ReadLine()!;
                Console.Write("Title: ");
                string title = Console.ReadLine()!;
                Console.Write("Author: ");
                string author = Console.ReadLine()!;
                library.AddBook(genre, title, author);
            }
            else if (choice == 2){
                Console.Write("Genre: ");
                string genre = Console.ReadLine()!;
                Console.Write("Title: ");
                string title = Console.ReadLine()!;
                Console.Write("Author: ");
                string author = Console.ReadLine()!;
                library.BorrowBook(genre, title, author);
            }
            else if (choice == 3){
                library.DisplayBooks();
            }

        } while (choice != 4);
    }
}
