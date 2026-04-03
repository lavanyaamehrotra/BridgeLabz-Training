using System;
class UndoRedoTextEditor{
    // Doubly Linked List Node
    class Node{
        public string Text;
        public Node Prev;
        public Node Next;
    }
    static Node head = null;
    static Node tail = null;
    static Node current = null;
    static int size = 0;
    static int Max = 10;
    // Add new text state
    static void AddState(string text){
        Node newNode = new Node();
        newNode.Text = text;
        // If first state
        if (head == null){
            head = tail = current = newNode;
            size = 1;
            return;
        }
        // Remove redo states
        if (current != tail){
            Node temp = current.Next;
            while (temp != null){
                Node next = temp.Next;
                temp = next;
                size--;
            }
            current.Next = null;
            tail = current;
        }
        // Add at end
        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
        current = newNode;
        size++;
        // Limit history to Max
        if (size > Max){
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }
    // Undo operation
    static void Undo(){
        if (current != null && current.Prev != null){
            current = current.Prev;
            Console.WriteLine("Undo performed");
        }
        else{
            Console.WriteLine("Nothing to undo");
        }
    }
    // Redo operation
    static void Redo(){
        if (current != null && current.Next != null){
            current = current.Next;
            Console.WriteLine("Redo performed");
        }
        else{
            Console.WriteLine("Nothing to redo");
        }
    }
    // Display current text
    static void DisplayCurrent(){
        if (current != null){
            Console.WriteLine("Current Text: " + current.Text);
        }else{
            Console.WriteLine("No text available.");
        }
    }
    static void Main(){
        int choice;
        string text;
        do{
            Console.WriteLine("\n--- Undo / Redo Text Editor ---");
            Console.WriteLine("1. Add Text");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. Display Current Text");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Enter Text: ");
                    text = Console.ReadLine();
                    AddState(text);
                    break;
                case 2:
                    Undo();
                    break;
                case 3:
                    Redo();
                    break;
                case 4:
                    DisplayCurrent();
                    break;
            }

        } while (choice != 5);
    }
}