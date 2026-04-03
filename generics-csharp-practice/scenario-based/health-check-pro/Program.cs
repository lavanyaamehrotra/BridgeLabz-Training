using System;
class Program{
    static void Main(){
        HealthCheckPro app = new HealthCheckPro();
        int choice;
        do{
            Console.WriteLine("\nHealthCheckPro Menu");
            Console.WriteLine("1. Validate API Annotations");
            Console.WriteLine("2. Generate API Documentation");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    app.ValidateAPIs();
                    break;
                case 2:
                    app.GenerateDocs();
                    break;
                case 3:
                    Console.WriteLine("Exiting HealthCheckPro");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 3);
    }
}
