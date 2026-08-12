using ContactsApp.Interfaces;
using ContactsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var contacts = _service.GetAll();

            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _service.GetById(id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            _service.Add(contact);

            return Ok(contact);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var existingContact = _service.GetById(id);

            if (existingContact == null)
            {
                return NotFound();
            }

            contact.ContactId = id;

            _service.Update(contact);

            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingContact = _service.GetById(id);

            if (existingContact == null)
            {
                return NotFound();
            }

            _service.Delete(id);

            return Ok("Contact deleted successfully");
        }
    }
}