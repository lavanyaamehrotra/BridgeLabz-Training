using System;
class Program{
    static void Main(){
        EventTracker tracker = new EventTracker();
        int choice;
        do{
            Console.WriteLine("\nEventTracker Menu");
            Console.WriteLine("1. Scan Audited Events");
            Console.WriteLine("2. View JSON Audit Logs");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    tracker.ScanAuditedEvents();
                    break;
                case 2:
                    tracker.ShowJsonLogs();
                    break;
                case 3:
                    Console.WriteLine("Exiting EventTracker...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 3);
    }
}
