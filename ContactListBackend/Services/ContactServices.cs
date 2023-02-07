using ContactListBackend.Models;
using ContactListBackend.Repository;

namespace ContactListBackend.Services
{
    public class ContactServices
    {
        public IContact _ContactRepository;

        public ContactServices(IContact contactRepository)
        {
            _ContactRepository = contactRepository;
        }

        public string SaveContact(Contact contacts)
        {
            return _ContactRepository.SaveContact(contacts);
        }

        public string DeleteContact(int id)
        {
            return _ContactRepository.DeleteContact(id);
        }

        public string UpdateContact(Contact contacts)
        {
            return _ContactRepository.UpdateContact(contacts);
        }

        public Contact GetContact(int id)
        {
            return _ContactRepository.GetContact(id);
        }

        public List<Contact> GetAllContact()
        {
            return _ContactRepository.GetAllContact();
        }
    }
}
