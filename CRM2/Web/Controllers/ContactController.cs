using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Crm.Data.Entities;
using Crm.Data;
using BugTrackerForX.Models;

namespace Crm.Controllers
{
    public class ContactController : ApiController
    {
        private readonly ContactRepository _contactRepository = new ContactRepository(new ContactAssistantContex("DefaultConnectionString"));
        
        public IEnumerable<Contact> Get()
        {
            return _contactRepository.GetAll();
        }

        // GET api/contact/5
        public Contact Get(int id)
        {
            return _contactRepository.Get(id);
        }

        // POST api/contact
        public void Post([FromBody]Contact contact)
        {
            _contactRepository.Add(contact);
        }

        // PUT api/contact/5
        public void Put(int id, [FromBody]Contact contact)
        {
            if (id == contact.Id)
            {
                _contactRepository.Edit(contact);
            }
        }

        // DELETE api/contact/5
        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

        //public Data.Entities.Contact contact { get; set; }
    }
}
