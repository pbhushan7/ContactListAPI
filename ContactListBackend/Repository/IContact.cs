using ContactListBackend.Models;

namespace ContactListBackend.Repository
{
    public interface IContact
    {
        public string SaveContact(Contact employee);
        public string UpdateContact(Contact employee);
        public string DeleteContact(int Id);
        public Contact GetContact(int Id);
        public List<Contact> GetAllContact();
    }
}
