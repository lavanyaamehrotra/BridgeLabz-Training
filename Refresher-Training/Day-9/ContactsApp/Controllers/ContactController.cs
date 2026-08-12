using ContactsApp.Data;
using ContactsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var contacts = _context.Contacts.ToList();

            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return Ok(contact);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var existingContact = _context.Contacts.Find(id);

            if (existingContact == null)
            {
                return NotFound();
            }

            existingContact.Name = contact.Name;
            existingContact.Email = contact.Email;
            existingContact.Phone = contact.Phone;
            existingContact.Address = contact.Address;
            existingContact.City = contact.City;
            existingContact.State = contact.State;

            _context.SaveChanges();

            return Ok(existingContact);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return NotFound();
            }

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return Ok("Contact deleted successfully");
        }
    }
}