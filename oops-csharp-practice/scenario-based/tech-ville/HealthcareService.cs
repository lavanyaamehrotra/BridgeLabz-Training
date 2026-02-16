using System;

public class HealthcareService : Service
{
    private string hospitalName;

    public HealthcareService(int id, string hospital)
        : base("Healthcare", id)
    {
        hospitalName = hospital;
    }

    public override void ProvideService()
    {
        Console.WriteLine(
            $"Healthcare service provided by {hospitalName} in {cityName}");
    }
}
