using System;
class TaskScheduler{
    // Node structure
    class Node{
        public int ID;
        public string Name;
        public int Priority;
        public string Due;
        public Node Next;
    }
    static Node head = null;
     // Add at Beginning
    static void AddAtBeginning(int id, string name, int priority, string date){
        Node newNode = new Node();
        newNode.ID = id;
        newNode.Name = name;
        newNode.Priority = priority;
        newNode.Due = date;
        if (head == null){
            head = newNode;
            newNode.Next = head;
        }
        else{
            Node temp = head;
            while (temp.Next != head){
                temp = temp.Next;
            }
            newNode.Next = head;
            temp.Next = newNode;
            head = newNode;
        }
        Console.WriteLine("Task added at beginning.");
    }
    // Add at End
    static void AddAtEnd(int id, string name, int priority, string date){
        Node newNode = new Node();
        newNode.ID = id;
        newNode.Name = name;
        newNode.Priority = priority;
        newNode.Due = date;
        if (head == null){
            head = newNode;
            newNode.Next = head;
            Console.WriteLine("Task added at end.");
            return;
        }
        Node temp = head;
        while (temp.Next != head){
            temp = temp.Next;
        }
        temp.Next = newNode;
        newNode.Next = head;
        Console.WriteLine("Task added at end.");
    }
    // Add at Specific Position
    static void AddAtPosition(int position, int id, string name, int priority, string date){
        if (position == 1){
            AddAtBeginning(id, name, priority, date);
            return;
        }
        Node newNode = new Node();
        newNode.ID = id;
        newNode.Name = name;
        newNode.Priority = priority;
        newNode.Due = date;
        Node temp = head;
        for (int i = 1; i < position - 1 && temp.Next != head; i++){
            temp = temp.Next;
        }
        newNode.Next = temp.Next;
        temp.Next = newNode;
        Console.WriteLine("Task added at position " + position);
    }
    // Remove by Task ID
    static void RemoveByTaskID(int id){
        if (head == null){
            Console.WriteLine("No tasks available.");
            return;
        }
        Node curr = head;
        Node prev = null;
        do{
            if (curr.ID == id){
                if (curr == head){
                    Node last = head;
                    while (last.Next != head){
                        last = last.Next;
                    }
                    head = head.Next;
                    last.Next = head;
                }
                else{
                    prev.Next = curr.Next;
                }
                Console.WriteLine("Task removed successfully");
                return;
            }
            prev = curr;
            curr = curr.Next;
        } while (curr != head);
        Console.WriteLine("Task not found.");
    }
    // View Current Task and Move to Next
    static void ViewCurrentTaskAndNextTask(){
        if (head == null){
            Console.WriteLine("No tasks available.");
            return;
        }
        Console.WriteLine("\nCurrent Task:");
        DisplayTask(head);
        head = head.Next;
        Console.WriteLine("Moved to next task.");
    }
    // Display All Tasks
    static void DisplayAll(){
        if (head == null){
            Console.WriteLine("No tasks available.");
            return;
        }
        Node temp = head;
        Console.WriteLine("\nAll Tasks:");
        do{
            DisplayTask(temp);
            temp = temp.Next;
        } while (temp != head);
    }
    // Search by Priority
    static void SearchByPriority(int priority){
        if (head == null){
            Console.WriteLine("No tasks available.");
            return;
        }

        Node temp = head;
        bool found = false;
        do{
            if (temp.Priority == priority){
                DisplayTask(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No task found");
    }
    static void DisplayTask(Node t){
        Console.WriteLine("Task ID: " + t.ID +", Name: " + t.Name +", Priority: " + t.Priority +", Due Date: " + t.Due);
    }
    static void Main(){
        int choice;
        do{
            Console.WriteLine("\n--- Task Scheduler ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Task ID");
            Console.WriteLine("5. View Current and Move Next");
            Console.WriteLine("6. Display All Tasks");
            Console.WriteLine("7. Search by Priority");
            Console.WriteLine("8. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    AddTask(1);
                    break;
                case 2:
                    AddTask(2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddTask(3, pos);
                    break;
                case 4:
                    Console.Write("Enter Task ID: ");
                    RemoveByTaskID(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    ViewCurrentTaskAndNextTask();
                    break;
                case 6:
                    DisplayAll();
                    break;
                case 7:
                    Console.Write("Enter priority: ");
                    SearchByPriority(int.Parse(Console.ReadLine()));
                    break;
            }

        } while (choice != 8);
    }

    static void AddTask(int type, int position = 0){
        Console.Write("Task ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Task Name: ");
        string name = Console.ReadLine();
        Console.Write("Priority: ");
        int priority = Convert.ToInt32(Console.ReadLine());
        Console.Write("Due Date: ");
        string date = Console.ReadLine();
        if (type == 1){
            AddAtBeginning(id, name, priority, date);
        }else if (type == 2){
            AddAtEnd(id, name, priority, date);
        }else{
            AddAtPosition(position, id, name, priority, date);
        }
    }
}
