using ContactsApp.Interfaces;
using ContactsApp.Models;

namespace ContactsApp.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;
        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }
        public List<Contact> GetAll()
        {
            return _repository.GetAll();
        }
        public Contact GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Add(Contact contact)
        {
            _repository.Add(contact);
        }
        public void Update(Contact contact)
        {
            _repository.Update(contact);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}