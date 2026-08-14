using ModelLayer.Entities;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _context;

        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }

        // CREATE
        public Contact AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return contact;
        }

        // READ ALL
        public List<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        // READ BY ID
        public Contact GetContactById(int id)
        {
            return _context.Contacts.FirstOrDefault(c => c.ContactId == id);
        }

        // UPDATE
        public Contact UpdateContact(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();

            return contact;
        }

        // DELETE
        public bool DeleteContact(int id)
        {
            var contact = _context.Contacts
                .FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
            {
                return false;
            }

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return true;
        }
    }
}