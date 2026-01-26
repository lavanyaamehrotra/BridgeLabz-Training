using System;
using NUnit.Framework;
public class DateFormatter{
    public string FormatDate(string inputDate){
        DateTime date;
        bool isValid = DateTime.TryParseExact(inputDate,"yyyy-MM-dd",null,System.Globalization.DateTimeStyles.None,out date);
        if(!isValid){
            throw new FormatException("Invalid date format");
        }
        return date.ToString("dd-MM-yyyy");
    }
}
[TestFixture]
public class DateFormatterTests{
    DateFormatter formatter;
    [SetUp]
    public void Setup(){
        formatter = new DateFormatter();
    }
    [Test]
    public void FormatDate_ValidDate_ReturnsFormattedDate(){
        string result = formatter.FormatDate("2024-08-15");
        Assert.AreEqual("15-08-2024", result);
    }
    [Test]
    public void FormatDate_AnotherValidDate(){
        Assert.AreEqual("01-01-2023", formatter.FormatDate("2023-01-01"));
    }
    [Test]
    public void FormatDate_InvalidDate_ThrowsException(){
        Assert.Throws<FormatException>(() => formatter.FormatDate("15-08-2024"));
    }
    [Test]
    public void FormatDate_InvalidInput_ThrowsException(){
        Assert.Throws<FormatException>(() => formatter.FormatDate("invalid-date"));
    }
}
