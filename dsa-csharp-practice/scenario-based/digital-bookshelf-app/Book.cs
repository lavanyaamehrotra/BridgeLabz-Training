using System;
// Encapsulated class
    class Book{
        public string Title { get; private set; }
        public string Author { get; private set; }
        // Constructor 
        public Book(string title, string author){
            Title = title;         
            Author=author;
        }
        public string GetFormattedBook(){
            return Title + " - " + Author;
        }
    }
