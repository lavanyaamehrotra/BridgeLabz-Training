using System;

// Custom Exception for Duplicate Citizen
public class DuplicateCitizenException : Exception
{
    public DuplicateCitizenException(string message): base(message){}
}
