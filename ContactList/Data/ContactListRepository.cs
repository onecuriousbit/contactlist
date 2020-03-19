namespace ContactList.Data
{
    using ContactList.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ContactListRepository
    {
        public IEnumerable<Contact> GetContacts()
        {
            using (var context = new ContactListEntities())
            {
                return context.GetContactList().Select(k => new Contact
                {
                    Id = k.Id,
                    FirstName = k.FirstName,
                    LastName = k.LastName,
                    Email = k.Email,
                    PhoneNumber = k.PhoneNumber,
                    Status = k.Status
                }).ToList();
            }
        }

        public IEnumerable<Contact> GetContactById(int id)
        {
            using (var context = new ContactListEntities())
            {
                return context.GetContactById(id).Select(k => new Contact
                {
                    Id = k.Id,
                    FirstName = k.FirstName,
                    LastName = k.LastName,
                    Email = k.Email,
                    PhoneNumber = k.PhoneNumber,
                    Status = k.Status
                }).ToList();
            }
        }

        public bool AddContact(Contact contact)
        {
            using (var context = new ContactListEntities())
            {
                var id = context.InsertContact(contact.FirstName,
                    contact.LastName, contact.Email,
                    contact.PhoneNumber, contact.Status).FirstOrDefault();

                return Convert.ToInt32(id) > 0;
            }
        }

        public void UpdateContact(Contact contact)
        {
            using (var context = new ContactListEntities())
            {
                context.EditContact(contact.Id, contact.FirstName,
                    contact.LastName, contact.Email,
                    contact.PhoneNumber, contact.Status);
            }
        }

        public void DeleteContact(int id)
        {
            using (var context = new ContactListEntities())
            {
                context.DeleteContact(id);
            }
        }
    }
}