using System.Text.RegularExpressions;
using NUnit.Framework;
public class PasswordValidator{
    // Checks if password meets strength rules
    public bool IsValid(string password){
        if(string.IsNullOrEmpty(password)){
            return false;
        }
        string pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
        return Regex.IsMatch(password, pattern);
    }
}
[TestFixture]
public class PasswordValidatorTests{
    PasswordValidator validator;
    [SetUp]
    public void Setup(){
        validator = new PasswordValidator();
    }
    [Test]
    public void ValidPassword_ReturnsTrue(){
        Assert.IsTrue(validator.IsValid("Password1"));
    }
    [Test]
    public void Password_TooShort_ReturnsFalse(){
        Assert.IsFalse(validator.IsValid("Pass1"));
    }
    [Test]
    public void Password_NoUppercase_ReturnsFalse(){
        Assert.IsFalse(validator.IsValid("password1"));
    }
    [Test]
    public void Password_NoDigit_ReturnsFalse(){
        Assert.IsFalse(validator.IsValid("Password"));
    }
}
