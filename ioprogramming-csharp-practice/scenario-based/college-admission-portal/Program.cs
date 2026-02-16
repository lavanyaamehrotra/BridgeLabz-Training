class Program
{
    static void Main()
    {
        RegistrationService service = new RegistrationService();

        string[] emails =
        {
            "john.doe@gmail.com",
            "megha_r92@outlook.in",
            "admin@blitz.edu",
            "john.doe@gmail",
            "@gmail.com",
            "raju#123@inbox.com"
        };

        foreach (var email in emails)
        {
            Student student = new Student(email);
            service.Register(student);
        }

        Console.ReadLine();
    }
}
