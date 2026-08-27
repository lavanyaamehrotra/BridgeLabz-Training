using FundooNotesApp.LabelService.DTOs;
using FundooNotesApp.LabelService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotesApp.LabelService.Controllers
{
    [Route("api/labels")]
    [ApiController]
    [Authorize]
    public class LabelController : ControllerBase
    {
        private readonly ILabelBL _labelBL;

        public LabelController(ILabelBL labelBL)
        {
            _labelBL = labelBL;
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

        [HttpPost("create")]
        public IActionResult CreateLabel([FromBody] CreateLabelDTO createLabelDTO)
        {
            try
            {
                int userId = GetUserId();
                var label = _labelBL.CreateLabel(createLabelDTO, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Label created successfully", Data = label });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("{labelId}")]
        public IActionResult GetLabelById(int labelId)
        {
            try
            {
                int userId = GetUserId();
                var label = _labelBL.GetLabelById(labelId, userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Label retrieved successfully", Data = label });
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

        [HttpGet("all")]
        public IActionResult GetAllLabels()
        {
            try
            {
                int userId = GetUserId();
                var labels = _labelBL.GetAllLabels(userId);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Labels retrieved successfully", Data = labels });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPut("{labelId}")]
        public IActionResult EditLabel(int labelId, [FromBody] EditLabelDTO editLabelDTO)
        {
            try
            {
                int userId = GetUserId();
                var label = _labelBL.EditLabel(labelId, userId, editLabelDTO);
                return Ok(new ResponseDTO<object> { Success = true, Message = "Label updated successfully", Data = label });
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

        [HttpDelete("{labelId}")]
        public IActionResult DeleteLabel(int labelId)
        {
            try
            {
                int userId = GetUserId();
                _labelBL.DeleteLabel(labelId, userId);
                return Ok(new ResponseDTO<string> { Success = true, Message = "Label deleted successfully" });
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
    }
}
