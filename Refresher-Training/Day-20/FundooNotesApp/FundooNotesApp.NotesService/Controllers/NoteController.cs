using FundooNotesApp.NotesService.DTOs;
using FundooNotesApp.NotesService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotesApp.NotesService.Controllers
{
    [Route("api/notes")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteBL _noteBL;

        public NoteController(INoteBL noteBL)
        {
            _noteBL = noteBL;
        }

        private int GetUserId()
        {
            var claim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(claim))
            {
                throw new UnauthorizedAccessException("UserId claim missing");
            }
            return int.Parse(claim);
        }

        [Authorize]
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

        [Authorize]
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

        [Authorize]
        [HttpGet("{noteId}")]
        public IActionResult GetNoteById(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.GetNoteById(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note retrieved successfully", Data = note });
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

        [Authorize]
        [HttpDelete("{noteId}")]
        public IActionResult DeleteNote(int noteId)
        {
            try
            {
                int userId = GetUserId();
                _noteBL.DeleteNote(noteId, userId);
                return Ok(new ResponseDTO<string> { Success = true, Message = "Note deleted successfully" });
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

        [Authorize]
        [HttpPatch("{noteId}/pin")]
        public IActionResult TogglePin(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.TogglePin(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note pin status updated", Data = note });
            }
            catch (KeyNotFoundException ex)
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

        [Authorize]
        [HttpPatch("{noteId}/archive")]
        public IActionResult ToggleArchive(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.ToggleArchive(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note archive status updated", Data = note });
            }
            catch (KeyNotFoundException ex)
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

        [Authorize]
        [HttpPatch("{noteId}/trash")]
        public IActionResult TrashNote(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.TrashNote(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note moved to trash", Data = note });
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

        [Authorize]
        [HttpPatch("{noteId}/restore")]
        public IActionResult RestoreNote(int noteId)
        {
            try
            {
                int userId = GetUserId();
                var note = _noteBL.RestoreNote(noteId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Note restored", Data = note });
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

        [Authorize]
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

        [Authorize]
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

        [HttpGet("internal/{noteId}")]
        public IActionResult GetNoteByIdInternal(int noteId)
        {
            var note = _noteBL.GetNoteByIdInternal(noteId);
            if (note == null)
            {
                return NotFound(new ResponseDTO<string> { Success = false, Message = "Note not found" });
            }

            return Ok(new ResponseDTO<object>
            {
                Success = true,
                Message = "Note found",
                Data = note
            });
        }
    }
}
