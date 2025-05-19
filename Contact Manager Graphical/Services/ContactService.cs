using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Graphical.Services
{
    public class ContactService
    {
        private List<Contact> contacts;

        public ContactService()
        {
           
            using (var context = new ContactmanagerContext())
            {
              contacts = new List<Contact>();
            }
        }

        // Добавяне на нов контакт
        public void AddContact(Contact contact)
        {
            
            using (var context = new ContactmanagerContext())
            {
               contacts.Add(contact);
            }
        }

        // Обновяване на съществуващ контакт
        public bool UpdateContact(int contactId, Contact updatedContact)
        {
            

            using (var context = new ContactmanagerContext())
            {
                var contact = contacts.FirstOrDefault(c => c.ContactId == contactId);
             if (contact != null)
             {
                 contact.FirstName = updatedContact.FirstName;
                 contact.SecondName = updatedContact.SecondName;
                 contact.Address = updatedContact.Address;
                 contact.PhoneNum = updatedContact.PhoneNum;
                contact.Email = updatedContact.Email;
                 contact.BirthDate = updatedContact.BirthDate;
                 contact.Tag = updatedContact.Tag;
                 return true;
             }
              return false;
            }
        }

        // Изтриване на контакт
        public bool DeleteContact(int contactId)
        {
            using (var context = new ContactmanagerContext())
            {
                var contact = contacts.FirstOrDefault(c => c.ContactId == contactId);
                if (contact != null)
                {
                    contacts.Remove(contact);
                    return true;
                }
                return false;
            }
        }

        // Намиране на контакт по ID
        public Contact GetContactById(int contactId)
        {
            
            using (var context = new ContactmanagerContext())
            {
               return contacts.FirstOrDefault(c => c.ContactId == contactId);
            }
        }

        // Връщане на всички контакти
        public List<Contact> GetAllContacts()
        {
            
            using (var context = new ContactmanagerContext())
            {
                return contacts;
            }
        }

        // Експортиране на контактите в .txt файл
        public void ExportContactsToTxt(string filePath)
        {
            

            using (var context = new ContactmanagerContext())
            {
              using (var writer = new StreamWriter(filePath))
              {
                foreach (var contact in contacts)
                {
                    writer.WriteLine($"ID: {contact.ContactId}");
                    writer.WriteLine($"First Name: {contact.FirstName}");
                    writer.WriteLine($"Second Name: {contact.SecondName}");
                    writer.WriteLine($"Address: {contact.Address}");
                    writer.WriteLine($"Phone Number: {contact.PhoneNum}");
                    writer.WriteLine($"Email: {contact.Email}");
                    writer.WriteLine($"Birth Date: {contact.BirthDate}");
                    writer.WriteLine($"Tag: {contact.Tag}");
                    writer.WriteLine(new string('-', 50)); 
                }
              }
            }
        }

        // Намиране на контакти по таг
        public List<Contact> GetContactsByTag(string tag)
        {
            using (var context = new ContactmanagerContext())
            {
              return contacts.Where(c => c.Tag.Equals(tag, StringComparison.OrdinalIgnoreCase)).ToList();
           
            }
        }
    }

    // Модел на контакт
    public class Contact
    {
        public int ContactId { get; set; } 
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; } 
        public string Tag { get; set; }

        public Contact(int contactId, string firstName, string secondName, string address,
                       string phoneNum, string email, string birthDate, string tag)
        {
            ContactId = contactId;
            FirstName = firstName;
            SecondName = secondName;
            Address = address;
            PhoneNum = phoneNum;
            Email = email;
            BirthDate = birthDate;
            Tag = tag;
        }
        
    }


}
