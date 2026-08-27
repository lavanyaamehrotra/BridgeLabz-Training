using System.Security.Claims;
using FundooNotesApp.UserManagementService.DTOs;
using FundooNotesApp.UserManagementService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotesApp.UserManagementService.Controllers
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
                    Message = "Reset token generated successfully",
                    Data = resetToken
                });
            }
            catch (KeyNotFoundException ex)
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
            catch (UnauthorizedAccessException ex)
            {
                return BadRequest(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("internal/{userId}")]
        public IActionResult GetUserInternal(int userId)
        {
            var user = _userBL.GetUserById(userId);
            if (user == null)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = "User not found" });
            }

            return Ok(new ResponseDTO<object>
            {
                Success = true,
                Message = "User found",
                Data = new { UserId = user.UserId, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName }
            });
        }
    }
}
