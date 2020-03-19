namespace ContactList.Controllers
{
    using ContactList.Entities;
    using ContactList.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Filters;

    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Contact> Get()
        {
            return new ContactModel().GetContacts();
        }

        // GET api/values/5
        public IEnumerable<Contact> Get(int id)
        {
            if (id > 0)
                return new ContactModel().GetContactById(id);
            else
                return Enumerable.Empty<Contact>();
        }

        // POST api/values
        public void Post([FromBody]Contact contact)
        {
            new ContactModel().AddContact(contact);
        }

        // PUT api/values/5
        public void Put([FromBody]Contact contact)
        {
            new ContactModel().UpdateContact(contact);
        }

        // PATCH api/values/5
        public void Patch(int id)
        {
            new ContactModel().DeleteContact(id);
        }
    }
}
