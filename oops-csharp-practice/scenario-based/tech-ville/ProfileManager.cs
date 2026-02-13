using System;
using System.Globalization;
public static class ProfileManager
{
    // Format Name (String Manipulation)
    public static string FormatName(string name)
    {
        name = name.Trim();
        return CultureInfo.CurrentCulture.TextInfo
               .ToTitleCase(name.ToLower());
    }
    // Email Validation
    public static bool ValidateEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
    // Extract City from Address
    public static string ExtractCity(string address)
    {
        string[] parts = address.Split(',');

        if (parts.Length >= 2)
            return parts[1].Trim();

        return "Unknown";
    }
    // Pass by Value Example
    public static void IncreaseAge(int age)
    {
        age += 1;
        Console.WriteLine("Age inside method: " + age);
    }
    // Pass by Reference Example
    public static void UpdateCitizen(ref Citizen citizen, string newName)
    {
        citizen.Name = FormatName(newName);
    }
    // Search using string matching
    public static void SearchCitizen(Citizen[] citizens, string searchName)
    {
        bool found = false;

        for (int i = 0; i < citizens.Length; i++)
        {
            if (citizens[i].Name.ToLower()
                .Contains(searchName.ToLower()))
            {
                Console.WriteLine("Match Found: " + citizens[i].Name);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No citizen found.");
    }
    // Profile Generator(MODULE 5)
    public static Citizen CreateProfile(Citizen[] existingCitizens)
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = FormatName(Console.ReadLine());
            // Check Duplicate
            for (int i = 0; i < existingCitizens.Length; i++)
            {
                if (existingCitizens[i] != null &&
                    existingCitizens[i].Name == name)
                {
                    throw new DuplicateCitizenException(
                        "Citizen with same name already exists.");
                }
            }
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (!ValidateEmail(email)){
                throw new FormatException("Invalid Email Format");
            }
            Console.Write("Enter Address (Street, City): ");
            string address = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 0)
                throw new InvalidAgeException("Age must be greater than 0");

            return new Citizen(name, email, address, age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine("Age Error: " + ex.Message);
            ErrorLogger.LogError(ex.Message);
        }
        catch (DuplicateCitizenException ex)
        {
            Console.WriteLine("Duplicate Error: " + ex.Message);
            ErrorLogger.LogError(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Format Error: " + ex.Message);
            ErrorLogger.LogError(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
            ErrorLogger.LogError(ex.Message);
        }
        finally
        {
            Console.WriteLine("Profile creation attempt completed.");
        }
        return null;
    }
}
