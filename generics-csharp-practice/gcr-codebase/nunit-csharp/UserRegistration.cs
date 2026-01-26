using System;
using NUnit.Framework;
public class UserRegistration{
    public void RegisterUser(string username, string email, string password){
        if(string.IsNullOrWhiteSpace(username)){
            throw new ArgumentException("Invalid username");
        }if(string.IsNullOrWhiteSpace(email) || !email.Contains("@")){
            throw new ArgumentException("Invalid email");
        }
        if(string.IsNullOrWhiteSpace(password) || password.Length < 6){
            throw new ArgumentException("Invalid password");
        }
    }
}
[TestFixture]
public class UserRegistrationTests{
    UserRegistration registration;
    [SetUp]
    public void Setup(){
        registration = new UserRegistration();
    }
    [Test]
    public void RegisterUser_ValidInputs_DoesNotThrow(){
        Assert.DoesNotThrow(() =>
            registration.RegisterUser("lavanya_mehrotra", "lavanya@example.com", "secret1")
        );
    }
    [Test]
    public void RegisterUser_InvalidUsername_ThrowsException(){
        Assert.Throws<ArgumentException>(() =>
            registration.RegisterUser("", "lavanya@example.com", "secret1")
        );
    }
    [Test]
    public void RegisterUser_InvalidEmail_ThrowsException(){
        Assert.Throws<ArgumentException>(() =>
            registration.RegisterUser("lavanya", "lavanyaexample.com", "secret1")
        );
    }
    [Test]
    public void RegisterUser_InvalidPassword_ThrowsException(){
        Assert.Throws<ArgumentException>(() =>
            registration.RegisterUser("lavanya", "lavanya@example.com", "123")
        );
    }
}
