using System;
class RoundRobin{
    // Node structure
    class Node{
    public int PID;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public Node Next;
}
static Node head = null;
static int processCount = 0;
// Add process at end
static void AddProcess(int pid, int burst, int priority){
    Node newNode = new Node();
    newNode.PID = pid;
    newNode.BurstTime = burst;
    newNode.RemainingTime = burst;
    newNode.Priority = priority;
    if (head == null){
            head = newNode;
            newNode.Next = head;
    }else{
        Node temp = head;
        while (temp.Next != head){
            temp = temp.Next;
        }
        temp.Next = newNode;
        newNode.Next = head;
    }
    processCount++;
    Console.WriteLine("Process added");
}
// Remove process by PID
    static void RemoveProcess(int pid){
        if (head == null){
            return;
        }
        Node curr = head, prev = null;
        do{
            if (curr.PID == pid){
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
                processCount--;
                return;
            }
            prev = curr;
            curr = curr.Next;
        } while (curr != head);
    }
    // Display processes
    static void DisplayProcesses(){
        if (head == null){
            Console.WriteLine("No processes remaining");
            return;
        }
        Node temp = head;
        Console.WriteLine("Processes in Queue:");
        do{
            Console.WriteLine("PID: " + temp.PID +", Remaining Time: " + temp.RemainingTime +", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }
    // Round Robin Scheduling
    static void RoundRobin(int timeQuantum){
        if (head == null){
            Console.WriteLine("No processes to schedule");
            return;
        }
        int time = 0;
        double totalWaiting = 0;
        double totalTurnaround = 0;
        Node temp = head;
        Console.WriteLine("\n------Round Robin Scheduling Started -----");
        while (processCount > 0){
            if (temp.RemainingTime > 0){
                Console.WriteLine("\nExecuting Process pid: " + temp.PID);
                if (temp.RemainingTime > timeQuantum){
                    time += timeQuantum;
                    temp.RemainingTime -= timeQuantum;
                }
                else{
                    time += temp.RemainingTime;
                    temp.RemainingTime = 0;
                    totalTurnaround += time;
                    totalWaiting += (time - temp.BurstTime);
                    int finishedPID = temp.PID;
                    temp = temp.Next;
                    RemoveProcess(finishedPID);
                    DisplayProcesses();
                    continue;
                }
            }
            temp = temp.Next;
            DisplayProcesses();
        }
        Console.WriteLine("\n--- Scheduling Completed ---");
        Console.WriteLine("Average Waiting Time: " + (totalWaiting));
        Console.WriteLine("Average Turnaround Time: " + (totalTurnaround));
    }
    static void Main(){
        int choice;
        do{
            Console.WriteLine("\n--- Round Robin Scheduling ---");
            Console.WriteLine("1. Add Process");
            Console.WriteLine("2. Start Scheduling");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Process ID: ");
                    int pid = int.Parse(Console.ReadLine());
                    Console.Write("Burst Time: ");
                    int burst = int.Parse(Console.ReadLine());
                    Console.Write("Priority: ");
                    int priority = int.Parse(Console.ReadLine());
                    AddProcess(pid, burst, priority);
                    break;
                case 2:
                    Console.Write("Enter Time Quantum: ");
                    int tq = int.Parse(Console.ReadLine());
                    RoundRobin(tq);
                    break;
            }

        } while (choice != 3);
    }
}
