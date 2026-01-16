// Custom linked list to store books of a genre

class BookLinkedList
{
    private BookNode? head;   // head can be null

    // Add book to the list
    public void Add(Book book)
    {
        BookNode node = new BookNode(book);

        // If list is empty
        if (head == null)
        {
            head = node;
            return;
        }

        // Traverse to the last node
        BookNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = node;
    }

    // Remove book from the list
    public void Remove(string key)
    {
        if (head == null)
        {
            return;
        }

        // If first node matches
        if (head.Data.Key() == key)
        {
            head = head.Next;
            return;
        }

        // Search remaining nodes
        BookNode current = head;
        while (current.Next != null)
        {
            if (current.Next.Data.Key() == key)
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }

    // Display all books in this list
    public void Display()
    {
        BookNode? temp = head;

        if (temp == null)
        {
            Console.WriteLine("No books available");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine(
                "Title: " + temp.Data.Title + ", Author: " + temp.Data.Author
            );
            temp = temp.Next;
        }
    }
}
