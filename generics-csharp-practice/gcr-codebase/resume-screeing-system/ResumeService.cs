using System;
public static class ResumeService{
    public static void AddResume<T>(Resume<T> resumeList) where T : JobRole {
        Console.Write("Candidate Name: ");
        string name = Console.ReadLine();
        Console.Write("Experience (years): ");
        int experience = int.Parse(Console.ReadLine());
        Console.Write("Skills: ");
        string skills = Console.ReadLine();
        if (typeof(T) == typeof(SoftwareEngineer)){
            Console.Write("Primary Programming Language: ");
            string lang = Console.ReadLine();
            var se = new SoftwareEngineer(name, experience, skills, lang);
            resumeList.AddResume((T)(object)se);
        }
        else if (typeof(T) == typeof(DataScientist)){
            Console.Write("Domain (AI/ML/Finance/etc): ");
            string domain = Console.ReadLine();
            var ds = new DataScientist(name, experience, skills, domain);
            resumeList.AddResume((T)(object)ds);
        }
        Console.WriteLine("Resume added succesfully!");
    }
}
