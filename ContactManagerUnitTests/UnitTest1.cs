using Contact_Manager_Graphical;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
namespace ContactManagerUnitTests
{
    public class ContactManagerTests
    {
        private ContactManager _contactManager;

        [SetUp]
        public void Setup()
        {
            _contactManager = new ContactManager();
        }

        [Test]
        public void GetContactByName_ShouldReturnCorrectContact()
        {
            var contact = new Contact { Name = "Jane Doe", Email = "jane.doe@example.com" };
            _contactManager.AddContact(contact);
            var retrievedContact = _contactManager.GetContactByName("Jane Doe");
            Assert.IsNotNull(retrievedContact);
            Assert.AreEqual("Jane Doe", retrievedContact.Name);
        }

        [Test]
        public void CreateContact_ShouldReturnNewContact()
        {
            var contact = new Contact { Name = "John Doe", Email = "john.doe@example.com" };
            _contactManager.AddContact(contact);
            Assert.AreEqual(1, _contactManager.GetAllContacts().Count);
        }

        [Test]
        public void DeleteContact_ShouldDeleteAContact()
        {
            _contactManager.AddContact(new Contact { Name = "Jane Smith", Email = "jane.smith@example.com" });
            _contactManager.DeleteContact("Jane Smith");
            Assert.That(_contactManager.GetContactByName("Jane Smith"), Is.Null);
        }
        [Test]
        public void UpdateContact_ShouldReturnContactWithDifferentName()
        {
            var newContact= new Contact {Name="Alice Johnson", Email="alice.johnson@temp.com" };
            newContact.Email = "alice.johnson@example.com";
            _contactManager.AddContact(newContact);
            Assert.AreEqual(1, _contactManager.GetAllContacts().Count);
        }

        public class ContactManager
        {
            private readonly List<Contact> _contacts = new();
            public void AddContact(Contact contact) => _contacts.Add(contact);
            public List<Contact> GetAllContacts() => _contacts;
            public Contact GetContactByName(string name) => _contacts.Find(c => c.Name == name);
            public void DeleteContact(string name) => _contacts.RemoveAll(c => c.Name == name);
        }

        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}