using System;
class Program{
    public static void Main(string[] args){
        Console.WriteLine("=== AI-DRIVEN RESUME SCREENING SYSTEM ===\n");
        var softwareEngineerResumes = new Resume<SoftwareEngineer>();
        var dataScientistResumes = new Resume<DataScientist>();
        bool exit = false;
        while (!exit){
            Console.WriteLine("\n1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. View All Resumes");
            Console.WriteLine("4. Search Resume by Name");
            Console.WriteLine("5. Filter Resumes by Experience");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    ResumeService.AddResume(softwareEngineerResumes);
                    break;
                case 2:
                    ResumeService.AddResume(dataScientistResumes);
                    break;
                case 3:
                    Console.WriteLine("\n--- Software Engineer Resumes ---");
                    softwareEngineerResumes.DisplayAll();
                    Console.WriteLine("\n--- Data Scientist Resumes ---");
                    dataScientistResumes.DisplayAll();
                    break;
                case 4:
                    Console.Write("\nEnter candidate name: ");
                    string name = Console.ReadLine();
                    var found =softwareEngineerResumes.SearchByName(name) ??dataScientistResumes.SearchByName(name);
                    if (found != null){
                        found.Display();
                    }else{
                        Console.WriteLine("Resume not found!");
                    }
                    break;
                case 5:
                    Console.Write("\nEnter minimum experience: ");
                    int minExp = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n--- Software Engineers ---");
                    foreach (var r in softwareEngineerResumes.FilterByExperience(minExp)){
                        r.Display();
                    }
                    Console.WriteLine("\n--- Data Scientists ---");
                    foreach (var r in dataScientistResumes.FilterByExperience(minExp)){
                        r.Display();
                    }
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
