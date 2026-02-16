using System;

public class EducationService : Service
{
    private string instituteName;

    public EducationService(int id, string institute)
        : base("Education", id)
    {
        instituteName = institute;
    }

    public override void ProvideService()
    {
        Console.WriteLine(
            $"Education service offered by {instituteName} in {cityName}");
    }
}
