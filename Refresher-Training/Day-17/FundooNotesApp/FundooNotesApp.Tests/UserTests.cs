using Microsoft.EntityFrameworkCore;
using FundooNotesApp.BusinessLayer.Services;
using FundooNotesApp.BusinessLayer.Helpers;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Services;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class UserTests
    {
        private FundooContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<FundooContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new FundooContext(options);
        }

        private UserBL GetUserBL(FundooContext context)
        {
            var userRL = new UserRL(context);
            var jwtHelper = new JwtTokenHelper("TestSecretKeyForUnitTesting123456!");
            return new UserBL(userRL, jwtHelper);
        }

        // ---------- Registration ----------

        [TestMethod]
        public void Register_ShouldSucceed_WhenEmailIsNew()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            var registrationDTO = new RegistrationDTO
            {
                FirstName = "New",
                LastName = "User",
                Email = "new@example.com",
                Password = "password123"
            };

            string result = userBL.Register(registrationDTO);

            Assert.AreEqual("Registration successful", result);
        }

        [TestMethod]
        public void Register_ShouldThrowException_WhenEmailAlreadyExists()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            var registrationDTO = new RegistrationDTO
            {
                FirstName = "Test",
                LastName = "User",
                Email = "duplicate@example.com",
                Password = "password123"
            };
            userBL.Register(registrationDTO);

            try
            {
                userBL.Register(registrationDTO);
                Assert.Fail("Expected UserAlreadyExistsException was not thrown");
            }
            catch (UserAlreadyExistsException) { }
        }

        // ---------- Login ----------

        [TestMethod]
        public void Login_ShouldReturnToken_WhenCredentialsAreCorrect()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            userBL.Register(new RegistrationDTO
            {
                FirstName = "Test",
                LastName = "User",
                Email = "login@example.com",
                Password = "password123"
            });

            var loginDTO = new LoginDTO { Email = "login@example.com", Password = "password123" };
            string token = userBL.Login(loginDTO);

            Assert.IsFalse(string.IsNullOrEmpty(token));
        }

        [TestMethod]
        public void Login_ShouldThrowException_WhenPasswordIsWrong()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            userBL.Register(new RegistrationDTO
            {
                FirstName = "Test",
                LastName = "User",
                Email = "login2@example.com",
                Password = "correctPassword"
            });

            var loginDTO = new LoginDTO { Email = "login2@example.com", Password = "wrongPassword" };

            try
            {
                userBL.Login(loginDTO);
                Assert.Fail("Expected InvalidCredentialsException was not thrown");
            }
            catch (InvalidCredentialsException) { }
        }

        [TestMethod]
        public void Login_ShouldThrowException_WhenUserDoesNotExist()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            var loginDTO = new LoginDTO { Email = "doesnotexist@example.com", Password = "anyPassword" };

            try
            {
                userBL.Login(loginDTO);
                Assert.Fail("Expected UserNotFoundException was not thrown");
            }
            catch (UserNotFoundException) { }
        }

        // ---------- Forget / Reset Password ----------

        [TestMethod]
        public void ForgetPassword_ShouldReturnToken_WhenEmailExists()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            userBL.Register(new RegistrationDTO
            {
                FirstName = "Test",
                LastName = "User",
                Email = "forgot@example.com",
                Password = "password123"
            });

            string resetToken = userBL.ForgetPassword(new ForgotPasswordDTO { Email = "forgot@example.com" });

            Assert.IsFalse(string.IsNullOrEmpty(resetToken));
        }

        [TestMethod]
        public void ForgetPassword_ShouldThrowException_WhenEmailNotFound()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            try
            {
                userBL.ForgetPassword(new ForgotPasswordDTO { Email = "notregistered@example.com" });
                Assert.Fail("Expected UserNotFoundException was not thrown");
            }
            catch (UserNotFoundException) { }
        }

        [TestMethod]
        public void ResetPassword_ShouldSucceed_WhenTokenIsValid()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            userBL.Register(new RegistrationDTO
            {
                FirstName = "Test",
                LastName = "User",
                Email = "reset@example.com",
                Password = "oldPassword123"
            });
            string resetToken = userBL.ForgetPassword(new ForgotPasswordDTO { Email = "reset@example.com" });

            string result = userBL.ResetPassword(new ResetPasswordDTO { Token = resetToken, NewPassword = "newPassword456" });

            Assert.AreEqual("Password has been reset successfully", result);

            // confirm login works with the NEW password now
            var loginDTO = new LoginDTO { Email = "reset@example.com", Password = "newPassword456" };
            string token = userBL.Login(loginDTO);
            Assert.IsFalse(string.IsNullOrEmpty(token));
        }

        [TestMethod]
        public void ResetPassword_ShouldThrowException_WhenTokenIsInvalid()
        {
            var context = GetInMemoryContext();
            var userBL = GetUserBL(context);

            try
            {
                userBL.ResetPassword(new ResetPasswordDTO { Token = "fake-invalid-token", NewPassword = "newPassword456" });
                Assert.Fail("Expected InvalidCredentialsException was not thrown");
            }
            catch (InvalidCredentialsException) { }
        }
    }
}