using FundooNotesApp.AuthService.DTOs;
using FundooNotesApp.AuthService.Helpers;
using FundooNotesApp.AuthService.Interfaces;
using FundooNotesApp.AuthService.Models;

namespace FundooNotesApp.AuthService.Services
{
    public class AuthBL : IAuthBL
    {
        private readonly IAuthRL _authRL;
        private readonly JwtTokenHelper _jwtTokenHelper;
        private readonly RedisCacheHelper _redisCacheHelper;

        public AuthBL(IAuthRL authRL, JwtTokenHelper jwtTokenHelper, RedisCacheHelper redisCacheHelper)
        {
            _authRL = authRL;
            _jwtTokenHelper = jwtTokenHelper;
            _redisCacheHelper = redisCacheHelper;
        }

        public string Register(RegisterRequest request)
        {
            var existingUser = _authRL.GetUserByEmail(request.Email);
            if (existingUser != null)
            {
                throw new Exception("A user with this email already exists");
            }

            string hashedPassword = PasswordEncryption.HashPassword(request.Password);

            var newUser = new UserEntity
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = hashedPassword
            };

            _authRL.Register(newUser);
            return "Registration successful";
        }

        public string Login(LoginRequest request)
        {
            var user = _authRL.GetUserByEmail(request.Email);
            if (user == null)
            {
                throw new KeyNotFoundException("No account found with this email");
            }

            bool isPasswordValid = PasswordEncryption.VerifyPassword(request.Password, user.PasswordHash);
            if (!isPasswordValid)
            {
                throw new UnauthorizedAccessException("Incorrect password");
            }

            string token = _jwtTokenHelper.GenerateToken(user.UserId, user.Email);

            // Store token in Redis Cache with 2-hour expiration
            _redisCacheHelper.StoreToken(user.Email, token, TimeSpan.FromHours(2));

            return token;
        }
    }
}
