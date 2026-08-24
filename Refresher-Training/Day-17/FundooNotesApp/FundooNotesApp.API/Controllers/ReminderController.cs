using FundooNotesApp.BusinessLayer.Interfaces;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.DTOs.ResponseDTO;
using FundooNotesApp.ModelLayer.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotesApp.API.Controllers
{
    [Route("api/reminders")]
    [ApiController]
    [Authorize]
    public class ReminderController : ControllerBase
    {
        private readonly IReminderBL _reminderBL;

        public ReminderController(IReminderBL reminderBL)
        {
            _reminderBL = reminderBL;
        }

        private int GetUserId()
        {
            return int.Parse(User.FindFirst("UserId")!.Value);
        }

        [HttpPost("create")]
        public IActionResult CreateReminder([FromBody] CreateReminderDTO createReminderDTO)
        {
            try
            {
                int userId = GetUserId();
                var reminder = _reminderBL.CreateReminder(createReminderDTO, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Reminder set successfully", Data = reminder });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("all")]
        public IActionResult GetAllReminders()
        {
            try
            {
                int userId = GetUserId();
                var reminders = _reminderBL.GetAllReminders(userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Reminders retrieved successfully", Data = reminders });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpDelete("{reminderId}")]
        public IActionResult DeleteReminder(int reminderId)
        {
            try
            {
                int userId = GetUserId();
                _reminderBL.DeleteReminder(reminderId, userId);
                return Ok(new ResponseDTO<string> { Success = true, Message = "Reminder removed successfully" });
            }
            catch (ReminderNotFoundException ex)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }
    }
}