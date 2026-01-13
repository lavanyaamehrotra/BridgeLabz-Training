using System;
   // Manages book collection and operations
   // Implements IBookOperations interface
    class BookManager : IBookOperations{
        private string[] books;
        private int count = 0;

        // Constructor
        public BookManager(int size){
            books = new string[size];
        }
        // Add book in "Title - Author" format 
        public void AddBook(string title, string author){
            books[count] = title + " - " + author;
            count++;
        }
        // Sort books alphabetically using Bubble Sort
        public void SortBooksAlphabetically(){
            for (int i = 0; i < count - 1; i++){
                for (int j = i + 1; j < count; j++) {
                    if (string.Compare(books[i], books[j]) > 0){
                        string temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nBooks sorted alphabetically.");
        }

        // Search books by author using String.Split()
        public void SearchByAuthor(string author){
            bool found = false;

            for (int i = 0; i < count; i++){                       
                string[] parts = books[i].Split('-');              
                string bookAuthor = parts[1].Trim();               
                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine(books[i]);                  
                    found = true;                            
                }
            }

            if (!found) {
                Console.WriteLine("No books found for the given author.");
            }
        }

        // Export books
        public void ExportBooks(){
            Console.WriteLine("\n Exported Book List:");
            for (int i = 0; i < count; i++){          
                Console.WriteLine(books[i]);
            }
        }
    }

