using FundooNotesApp.BusinessLayer.Interfaces;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.DTOs.ResponseDTO;
using FundooNotesApp.ModelLayer.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace FundooNotesApp.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL _userBL;

        public UserController(IUserBL userBL)
        {
            _userBL = userBL;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegistrationDTO registrationDTO)
        {
            try
            {
                string message = _userBL.Register(registrationDTO);
                return Ok(new ResponseDTO<string> { Success = true, Message = message });
            }
            catch (UserAlreadyExistsException ex)
            {
                return Conflict(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            try
            {
                string token = _userBL.Login(loginDTO);
                return Ok(new ResponseDTO<string> { Success = true, Message = "Login successful", Data = token });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (InvalidCredentialsException ex)
            {
                return Unauthorized(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [Authorize]
        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            string? userId = User.FindFirst("UserId")?.Value;
            string? email = User.FindFirst(ClaimTypes.Email)?.Value;

            return Ok(new ResponseDTO<object>
            {
                Success = true,
                Message = "You are authenticated!",
                Data = new { UserId = userId, Email = email }
            });
        }

        [HttpPost("forget-password")]
        public IActionResult ForgetPassword([FromBody] ForgotPasswordDTO forgetPasswordDTO)
        {
            try
            {
                string resetToken = _userBL.ForgetPassword(forgetPasswordDTO);
                return Ok(new ResponseDTO<string>
                {
                    Success = true,
                    Message = "Reset token generated. (Email sending will be added later.)",
                    Data = resetToken
                });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPost("reset-password")]
        public IActionResult ResetPassword([FromBody] ResetPasswordDTO resetPasswordDTO)
        {
            try
            {
                string message = _userBL.ResetPassword(resetPasswordDTO);
                return Ok(new ResponseDTO<string> { Success = true, Message = message });
            }
            catch (InvalidCredentialsException ex)
            {
                return BadRequest(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [Authorize]
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            try
            {
                string email = User.FindFirst(ClaimTypes.Email)!.Value;
                _userBL.Logout(email);
                return Ok(new ResponseDTO<string> { Success = true, Message = "Logged out successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }
    }
}