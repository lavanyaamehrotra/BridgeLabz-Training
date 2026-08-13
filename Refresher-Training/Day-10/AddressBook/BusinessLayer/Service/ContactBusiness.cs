using BusinessLayer.Interface;
using ModelLayer.Dtos;
using ModelLayer.Entities;
using RepositoryLayer.Interface;
using ModelLayer.Exceptions;

namespace BusinessLayer.Service
{
    public class ContactBusiness : IContactBusiness
    {
        private readonly IContactRepository _repository;
        public ContactBusiness(IContactRepository repository)
        {
            _repository = repository;
        }
        // CREATE
        public Contact AddContact(ContactDto contactDto)
        {
            Contact contact = new Contact
            {
                Name = contactDto.Name,
                PhoneNumber = contactDto.PhoneNumber,
                Email = contactDto.Email,
                Address = contactDto.Address
            };
            return _repository.AddContact(contact);
        }

        // READ ALL
        public List<Contact> GetAllContacts()
        {
            return _repository.GetAllContacts();
        }

        // READ BY ID
        public Contact GetContactById(int id)
        {
            return _repository.GetContactById(id);
        }

        // UPDATE
        public Contact UpdateContact(int id, ContactDto contactDto)
        {
            var existingContact = _repository.GetContactById(id);
            if (existingContact == null)
            {
                throw new ContactNotFoundException($"Contact with ID {id} not found.");
            }
            existingContact.Name = contactDto.Name;
            existingContact.PhoneNumber = contactDto.PhoneNumber;
            existingContact.Email = contactDto.Email;
            existingContact.Address = contactDto.Address;
            return _repository.UpdateContact(existingContact);
        }

        // DELETE
        public bool DeleteContact(int id)
        {
            return _repository.DeleteContact(id);
        }
    }
}