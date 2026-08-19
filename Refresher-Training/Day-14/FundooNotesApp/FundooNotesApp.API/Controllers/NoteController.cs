using FundooNotesApp.BusinessLayer.Interfaces;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.DTOs.ResponseDTO;
using FundooNotesApp.ModelLayer.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotesApp.API.Controllers
{
    [Route("api/notes")]
    [ApiController]
    [Authorize]
    public class NoteController : ControllerBase
    {
        private readonly INoteBL _noteBL;

        public NoteController(INoteBL noteBL)
        {
            _noteBL = noteBL;
        }

        private int GetUserId()
        {
            return int.Parse(User.FindFirst("UserId")!.Value);
        }

        [HttpPost("create")]
        public IActionResult CreateNote([FromBody] CreateNoteDTO createNoteDTO)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.CreateNote(createNoteDTO, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note created successfully", Data = note });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("all")]
        public IActionResult GetAllNotes()
        {
            try
            {
                int userId = GetUserId();
                var notes = _noteBL.GetAllNotes(userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Notes retrieved successfully", Data = notes });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("{noteId}")]
        public IActionResult GetNoteById(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.GetNoteById(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note retrieved successfully", Data = note });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpDelete("{noteId}")]
        public IActionResult DeleteNote(int noteId)
        {
            try
            {
                int userId = GetUserId();
                _noteBL.DeleteNote(noteId, userId);
                return Ok(new ResponseDTO<string> { Success = true, Message = "Note deleted successfully" });
            }
            catch (NoteNotFoundException ex)
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