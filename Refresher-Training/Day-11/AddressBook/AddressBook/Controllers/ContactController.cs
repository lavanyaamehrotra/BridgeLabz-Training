using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Dtos;
using ModelLayer.Exceptions;

namespace AddressBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactBusiness _business;
        public ContactController(IContactBusiness business)
        {
            _business = business;
        }
        // CREATE
        [HttpPost]
        public IActionResult AddContact(ContactDto contactDto)
        {
            var contact = _business.AddContact(contactDto);
            return Ok(contact);
        }
        // READ ALL
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = _business.GetAllContacts();
            return Ok(contacts);
        }

        // READ BY ID
        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            try
            {
                var contact = _business.GetContactById(id);

                return Ok(contact);
            }
            catch (ContactNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, ContactDto contactDto)
        {
            var contact = _business.UpdateContact(id, contactDto);
            if (contact == null)
            {
                return NotFound("Contact not found");
            }
            return Ok(contact);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var result = _business.DeleteContact(id);
            if (!result)
            {
                return NotFound("Contact not found");
            }
            return Ok("Contact deleted successfully");
        }
    }
}