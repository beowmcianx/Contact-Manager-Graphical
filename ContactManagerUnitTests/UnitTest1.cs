using Contact_Manager_Graphical;
using Contact_Manager_Graphical.Models;
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
        public void GetNonexistentContact_ShouldNotReturnContact()
        {
            var retrievedContact = _contactManager.GetContactByName("Jane Mane");
            Assert.IsNotNull(retrievedContact);
            Assert.AreEqual("Jane Mane", retrievedContact.Name);
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
        public void DeleteNonexistentContact_ShouldNotDeleteAContact()
        {
            _contactManager.DeleteContact("Jane Mane");
            Assert.That(_contactManager.GetContactByName("Jane Mane"), Is.Null);
        }
        
        [Test]
        public void UpdateContact_ShouldReturnContactWithDifferentName()
        {
            var newContact= new Contact {Name="Alice Johnson", Email="alice.johnson@temp.com" };
            newContact.Email = "alice.johnson@example.com";
            _contactManager.AddContact(newContact);
            Assert.AreEqual(1, _contactManager.GetAllContacts().Count);
        }

        [Test]
        public void GetTagByName_ShouldReturnCorrectTag()
        {
            var tag = new Tag { NameT = "School"};
            _contactManager.AddTag(tag);
            var retrievedTag = _contactManager.GetTagByName("School");
            Assert.IsNotNull(retrievedTag);
            Assert.AreEqual("School", retrievedTag.NameT);
        }

        [Test]
        public void GetNonexistentTag_ShouldNotReturnTag()
        {
            var retrievedTag = _contactManager.GetTagByName("fsgsd");
            Assert.IsNotNull(retrievedTag);
            Assert.AreEqual("fsgsd", retrievedTag.NameT);
        }

        [Test]
        public void CreateTag_ShouldReturnNewTag()
        {
            var tag = new Tag { NameT = "Work"};
            _contactManager.AddTag(tag);
            Assert.AreEqual(1, _contactManager.GetAllTags().Count);
        }

        [Test]
        public void DeleteTag_ShouldDeleteATag()
        {
            _contactManager.AddTag(new Tag { NameT = "Gym"});
            _contactManager.DeleteTag("Gym");
            Assert.That(_contactManager.GetTagByName("Gym"), Is.Null);
        }

        [Test]
        public void UpdateTag_ShouldReturnTagWithDifferentName()
        {
            var newTag = new Tag { NameT = "Uni"};
            newTag.NameT = "University";
            _contactManager.AddTag(newTag);
            Assert.AreEqual(1, _contactManager.GetAllTags().Count);
        }

        public class ContactManager
        {
            private readonly List<Contact> _contacts = new();
            private readonly List<Tag> _tags = new();
            public void AddContact(Contact contact) => _contacts.Add(contact);
            public void AddTag(Tag tag) => _tags.Add(tag);
            public List<Contact> GetAllContacts() => _contacts;
            public List<Tag> GetAllTags() => _tags;
            public Contact GetContactByName(string name) => _contacts.Find(c => c.Name == name);
            public Tag GetTagByName(string nameT) => _tags.Find(t => t.NameT == nameT);
            public void DeleteContact(string name) => _contacts.RemoveAll(c => c.Name == name);
            public void DeleteTag(string nameT) => _tags.RemoveAll(t => t.NameT == nameT);
        }

        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
        public class Tag
        {  public string NameT { get; set; }}
    }
}