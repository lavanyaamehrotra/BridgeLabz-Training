using System;

    class Program{
        static void Main(string[] args) {
            Console.Write("Enter number of books: ");
            int size = int.Parse(Console.ReadLine());
            // Interface reference = Polymorphism
            IBookOperations manager = new BookManager(size);
            for (int i = 0; i < size; i++) {               
                Console.Write("\nEnter book title: ");
                string title = Console.ReadLine();
                Console.Write("Enter author name: ");
                string author = Console.ReadLine();
                manager.AddBook(title, author);   
            }
            manager.SortBooksAlphabetically();     
            Console.Write("\nEnter author name to search: ");
            string searchAuthor = Console.ReadLine();
            manager.SearchByAuthor(searchAuthor);
            manager.ExportBooks();
        }
    }

