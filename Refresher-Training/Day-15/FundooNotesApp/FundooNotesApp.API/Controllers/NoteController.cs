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
        [HttpPatch("{noteId}/pin")]
        public IActionResult TogglePin(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.TogglePin(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note pin status updated", Data = note });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPatch("{noteId}/archive")]
        public IActionResult ToggleArchive(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.ToggleArchive(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note archive status updated", Data = note });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

       [HttpPatch("{noteId}/trash")]
        public IActionResult TrashNote(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.TrashNote(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note moved to trash", Data = note });
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

        [HttpPatch("{noteId}/restore")]
        public IActionResult RestoreNote(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.RestoreNote(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note restored", Data = note });
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

        [HttpGet("search")]
        public IActionResult SearchNotes([FromQuery] string keyword)
        {
            try
            {
                int userId = GetUserId();
                var notes = _noteBL.SearchNotes(userId, keyword);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Search results", Data = notes });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("filter")]
        public IActionResult FilterNotesByText([FromQuery] string searchText)
        {
            try
            {
                int userId = GetUserId();
                var notes = _noteBL.FilterNotesByText(userId, searchText);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Filtered notes", Data = notes });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }
    }
}