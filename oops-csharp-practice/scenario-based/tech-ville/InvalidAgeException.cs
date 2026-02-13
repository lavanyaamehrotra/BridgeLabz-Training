using System;

// Custom Exception for Invalid Age
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message): base(message){}
}
