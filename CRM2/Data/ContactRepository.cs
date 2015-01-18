using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Crm.Data.Entities;

namespace Data 
{
    public class ContactRepository
    {
        private readonly ContactAssistantContex _contex;

        public ContactRepository(ContactAssistantContex contex)
        {
            _contex = contex;
        }

        public IEnumerable<Contact> GetAll()
        {
            return _contex.Contacts;
        }

        public Contact Get(int contactId)
        {
            return _contex.Contacts.Find(contactId);
        }

        public void Add(Contact contact)
        {
            _contex.Contacts.Add(contact);
            _contex.SaveChanges();
        }

        public void Edit(Contact contact)
        {
            _contex.Entry(contact).State = EntityState.Modified;
            _contex.SaveChanges();
        }

        public void Delete(int contactId)
        {
            var contact = _contex.Contacts.Find(contactId);
            if (contact != null)
            {
                _contex.Contacts.Remove(contact);
                _contex.SaveChanges();
            }
        }
      
    }
}
