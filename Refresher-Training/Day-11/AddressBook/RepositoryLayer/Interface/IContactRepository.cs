using ModelLayer.Entities;

namespace RepositoryLayer.Interface
{
    public interface IContactRepository
    {
        Contact AddContact(Contact contact);

        List<Contact> GetAllContacts();

        Contact GetContactById(int id);

        Contact UpdateContact(Contact contact);

        bool DeleteContact(int id);
    }
}