using ContactListBackend.Data;
using ContactListBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactListBackend.Repository
{
    public class ContactRepo : IContact
    {
        private DataContext _DataContext;
        public ContactRepo(DataContext ContactDB)
        {
            _DataContext = ContactDB;
        }
        public string DeleteContact(int Id)
        {
            string msg = "";
            Contact deleteContact = _DataContext.contacts.Find(Id);
            if (deleteContact != null)
            {
                _DataContext.contacts.Remove(deleteContact);
                _DataContext.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<Contact> GetAllContact()
        {
            List<Contact> contacts = _DataContext.contacts.ToList();
            return contacts;
        }

        public Contact GetContact(int Id)
        {
            Contact contacts = _DataContext.contacts.Find(Id);
            return contacts;
        }

        public string SaveContact(Contact contacts)
        {
            _DataContext.contacts.Add(contacts);
            _DataContext.SaveChanges();
            return "Saved";
        }

        public string UpdateContact(Contact contacts)
        {
            _DataContext.Entry(contacts).State = EntityState.Modified;
            _DataContext.SaveChanges();
            return "Updated";
        }
    }
}
