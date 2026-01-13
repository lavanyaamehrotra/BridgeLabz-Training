using System;
// Interface for book operations
    interface IBookOperations{
        void AddBook(string title, string author);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
        void ExportBooks();
    }

