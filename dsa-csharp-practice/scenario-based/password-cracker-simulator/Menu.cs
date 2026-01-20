using System;
public class Menu {
    public void Show(){
        BacktrackingEngine engine = null;
        ComplexityAnalyzer analyzer = new ComplexityAnalyzer();
        while(true){
            Console.WriteLine("\n--- PASSWORD CRACKER MENU ---");
            Console.WriteLine("1. Enter Password");
            Console.WriteLine("2. Start Cracking");
            Console.WriteLine("3. View Complexity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine()!);
            switch(choice){
                case 1:
                    Console.Write("Set Password: ");
                    string pwd = Console.ReadLine()!;
                    engine = new BacktrackingEngine(pwd);
                    Console.WriteLine("Password stored!");
                    break;
                case 2:
                    if(engine == null){
                        Console.WriteLine("Please enter password first!");
                    } else {
                        engine.StartCracking();
                    }
                    break;
                case 3:
                    Console.Write("Enter password length: ");
                    int n = int.Parse(Console.ReadLine()!);
                    analyzer.Explain(3, n);
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
