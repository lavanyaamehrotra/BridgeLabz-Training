using System;

public class PremiumEducationService : EducationService
{
    private string extraCourse;

    public PremiumEducationService(int id, string institute, string course)
        : base(id, institute)
    {
        this.extraCourse = course;
    }

    public override void ProvideService()
    {
        base.ProvideService();
        Console.WriteLine("Extra Course Access: " + extraCourse);
    }
}
