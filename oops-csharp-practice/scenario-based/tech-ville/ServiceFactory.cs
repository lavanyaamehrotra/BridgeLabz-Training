using System;

public static class ServiceFactory
{
    public static Service CreateService(string type)
    {
        if (type.ToLower() == "healthcare")
            return new HealthcareService(401, "City Hospital");

        else if (type.ToLower() == "education")
            return new EducationService(402, "City College");

        else if (type.ToLower() == "premiumhealthcare")
            return new PremiumHealthcareService(403,
                "Super Hospital", "24/7 Doctor Access");

        else if (type.ToLower() == "premiumeducation")
            return new PremiumEducationService(404,
                "Elite Institute", "AI Certification");

        return null;
    }
}
