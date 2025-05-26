using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManagerConsoleApp.Bussiness_Layer
{
    internal class Services
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


        public void CreateContact(Person person, Contact contact, List<string> tagNames)
        {
            using (var context = new ContactmanagerContext())
            {

                foreach (var tagName in tagNames)
                {
                    var existingTag = context.Tags.FirstOrDefault(t => t.Name == tagName);
                    if (existingTag == null)
                    {
                        existingTag = new Tag { Name = tagName };
                        context.Tags.Add(existingTag);
                    }
                    contact.Tags.Add(existingTag);
                }

                person.Contacts.Add(contact);
                context.People.Add(person);
                context.SaveChanges();
            }

        }
     


        public void UpdateContact(string firstName, string lastName,
           string? newAddress, DateOnly? newBirthDate,
           long? newPhoneNum, string? newEmail,
           List<string> tagsToAdd, List<string> tagsToRemove)
        {
            var person = context.People
                .Include(p => p.Contacts)
                .ThenInclude(c => c.Tags)
                .FirstOrDefault(p => p.FirstName == firstName && p.SecondName == lastName);

            if (person == null)
                throw new Exception("Person not found");

            
            if (newAddress != null)
                person.Address = newAddress;

            if (newBirthDate.HasValue)
                person.BirthDate = newBirthDate;

            var contact = person.Contacts.FirstOrDefault();
            if (contact != null)
            {
                if (newPhoneNum.HasValue)
                    contact.PhoneNum = newPhoneNum.Value;

                if (newEmail != null)
                    contact.Email = newEmail;
            }

          
            foreach (var tagName in tagsToAdd)
            {
                var tag = context.Tags.FirstOrDefault(t => t.Name == tagName);
                if (tag != null && !contact.Tags.Any(t => t.Name == tagName))
                {
                    contact.Tags.Add(tag);
                }
            }

    
            foreach (var tag in contact.Tags.ToList())
            {
                if (tagsToRemove.Contains(tag.Name))
                {
                    contact.Tags.Remove(tag);
                }
            }

            context.SaveChanges();
        }

    }
}
