using System;

public class PremiumHealthcareService : HealthcareService
{
    private string premiumFeature;

    public PremiumHealthcareService(int id, string hospital, string feature)
        : base(id, hospital)
    {
        this.premiumFeature = feature; // THIS keyword
    }

    public override void ProvideService()
    {
        base.ProvideService(); // SUPER keyword equivalent
        Console.WriteLine("Premium Feature: " + premiumFeature);
    }
}
