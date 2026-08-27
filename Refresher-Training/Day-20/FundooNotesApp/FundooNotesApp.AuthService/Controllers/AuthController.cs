using System.Security.Claims;
using FundooNotesApp.AuthService.DTOs;
using FundooNotesApp.AuthService.Helpers;
using FundooNotesApp.AuthService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotesApp.AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthBL _authBL;
        private readonly RedisCacheHelper _redisCacheHelper;

        public AuthController(IAuthBL authBL, RedisCacheHelper redisCacheHelper)
        {
            _authBL = authBL;
            _redisCacheHelper = redisCacheHelper;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            try
            {
                var message = _authBL.Register(request);
                return Ok(new ResponseDTO<string> { Success = true, Message = message, Data = null });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            try
            {
                var token = _authBL.Login(request);
                return Ok(new ResponseDTO<string> { Success = true, Message = "Login successful", Data = token });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [Authorize]
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            var emailClaim = User.FindFirst(ClaimTypes.Email)?.Value;

            if (!string.IsNullOrEmpty(emailClaim))
            {
                _redisCacheHelper.RemoveToken(emailClaim);
            }

            return Ok(new ResponseDTO<string> { Success = true, Message = "Logged out successfully", Data = null });
        }

        [HttpPost("validate")]
        public IActionResult ValidateToken([FromBody] ValidateTokenDTO request)
        {
            bool isValid = _redisCacheHelper.ValidateToken(request.Email, request.Token);
            if (isValid)
            {
                return Ok(new ResponseDTO<bool> { Success = true, Message = "Token is valid", Data = true });
            }

            return Unauthorized(new ResponseDTO<bool> { Success = false, Message = "Token is invalid or expired", Data = false });
        }
    }
}
