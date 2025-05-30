using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManagerConsoleApp.Service
{
    public class Services
    {
        private readonly ContactmanagerContext context;

        public Services()
        {
            context = new ContactmanagerContext();
        }

        public Tag GetTagByName(string name)
        {
            using (var context = new ContactmanagerContext())
            {
                return context.Tags.FirstOrDefault(t => t.Name == name);
            }

        }
        public List<Person> GetAllPeople()
        {
            return context.People
                .Include(p => p.Contacts)
                .ThenInclude(c => c.Tags)
                .ToList();
        }
        public Person? GetPersonByName(string firstName, string lastName)
        {
            return context.People
                .Include(p => p.Contacts)
                .ThenInclude(c => c.Tags)
                .FirstOrDefault(p => p.FirstName == firstName && p.SecondName == lastName);
        }
        public bool Delete(string FirstName, string LastName)
        {
            using var context = new ContactmanagerContext();

            
            var person = context.People.FirstOrDefault(p => p.FirstName == FirstName && p.SecondName == LastName);
            if (person == null) return false;

            var contacts = context.Contacts
                 .Where(c => c.PersonId == person.PersonId)
                 .Include(c => c.Tags)
                 .ToList();

            foreach (var contact in contacts)
            {
                contact.Tags.Clear();
            }
            context.SaveChanges();
            context.Contacts.RemoveRange(contacts);
            context.SaveChanges();
            context.People.Remove(person);
            context.SaveChanges();

            return true;
        }

        public bool CreateContact(string firstName, string secondName, string address, DateOnly birthDate, long phoneNum, string email, List<string> tagNames)
        {
            using (var context = new ContactmanagerContext())
            {
                var existingPerson = context.People
                    .Include(c => c.Contacts)
                    .ThenInclude(c => c.Tags)
                    .FirstOrDefault(p => p.FirstName == firstName && p.SecondName == secondName);

                if (existingPerson != null)
                {
                    return false;
                }

                var newPerson = new Person
                {
                    FirstName = firstName,
                    SecondName = secondName,
                    Address = address,
                    BirthDate = birthDate
                };

                var newContact = new Contact
                {
                    PhoneNum = phoneNum,
                    Email = email,
                    CreationDate = DateOnly.FromDateTime(DateTime.Now),
                    Tags = new List<Tag>()
                };

                foreach (var tagName in tagNames)
                {
                    var existingTag = context.Tags.FirstOrDefault(t => t.Name == tagName);
                    if (existingTag == null)
                    {
                        existingTag = new Tag { Name = tagName };
                        context.Tags.Add(existingTag);
                    }
                    newContact.Tags.Add(existingTag);
                }

                newPerson.Contacts.Add(newContact);
                context.People.Add(newPerson);
                context.SaveChanges();

                return true;
            }


        }
    }
}




        

