namespace ContactList.Models
{
    using ContactList.Data;
    using ContactList.Entities;
    using System.Collections.Generic;

    public class ContactModel
    {
        private readonly ContactListRepository contactListRepository;

        public ContactModel()
        {
            contactListRepository = new ContactListRepository();
        }

        public IEnumerable<Contact> GetContacts()
        {
            return contactListRepository.GetContacts();
        }

        public IEnumerable<Contact> GetContactById(int id)
        {
            return contactListRepository.GetContactById(id);
        }

        public bool AddContact(Contact contact)
        {
            return contactListRepository.AddContact(contact);
        }

        public void UpdateContact(Contact contact)
        {
            contactListRepository.UpdateContact(contact);
        }

        public void DeleteContact(int id)
        {
            contactListRepository.DeleteContact(id);
        }
    }
}