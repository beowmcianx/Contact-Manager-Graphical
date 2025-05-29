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

        /// <summary>
        /// Инициализира нов екземпляр на класа <see cref="ContactService"/>.
        /// </summary>
        /// <remarks>
        /// Конструкторът създава празен списък <see cref="contacts"/>, 
        /// който може да се използва за локално съхранение на контакти.
        public ContactService()
        {
           
            using (var context = new ContactmanagerContext())
            {
              contacts = new List<Contact>();
            }
        }

        /// <summary>
        /// Добавя нов обект <see cref="Contact"/> към базата данни.
        /// </summary>
        /// <param name="contact">Обект от тип <see cref="Contact"/>, съдържащ информацията за контакт.</param>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за създаване на нов запис в базата данни.
        /// След добавянето, промените се записват чрез <c>context.SaveChanges()</c>.
        /// </remarks>
        public void AddContact(Contact contact)
        {
            
            using (var context = new ContactmanagerContext())
            {
               contacts.Add(contact);
            }
        }

        /// <summary>
        /// Актуализира съществуващ обект <see cref="Contact"/> в базата данни по неговото ID.
        /// </summary>
        /// <param name="contactId">Уникалният идентификатор на контакта за актуализация.</param>
        /// <param name="updatedContact">Обект с новите данни, които трябва да се приложат.</param>
        /// <returns>
        /// Връща <c>true</c>, ако контактът е намерен и успешно актуализиран; 
        /// в противен случай връща <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за достъп до базата данни.
        /// Промените се записват чрез <c>context.SaveChanges()</c>.
        /// </remarks>
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

        /// <summary>
        /// Изтрива обект <see cref="Contact"/> от базата данни по зададено ID.
        /// </summary>
        /// <param name="contactId">Уникалният идентификатор на контакта за изтриване.</param>
        /// <returns>
        /// Връща <c>true</c>, ако контактът е намерен и успешно изтрит; в противен случай <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за достъп до базата данни.
        /// Промените се записват чрез <c>context.SaveChanges()</c>.
        /// </remarks>
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

        /// <summary>
        /// Връща обект <see cref="Contact"/> от базата данни по зададено ID.
        /// </summary>
        /// <param name="contactId">Уникалният идентификатор на контакта.</param>
        /// <returns>
        /// Обект <see cref="Contact"/>, ако е намерен; в противен случай <c>null</c>.
        /// </returns>
        /// <remarks>Използва <see cref="ContactmanagerContext"/> за достъп до данните.</remarks>
        public Contact GetContactById(int contactId)
        {
            
            using (var context = new ContactmanagerContext())
            {
               return contacts.FirstOrDefault(c => c.ContactId == contactId);
            }
        }

        /// <summary>
        /// Връща списък с всички контакти от базата данни.
        /// </summary>
        /// <returns>Списък от обекти <see cref="Contact"/>.</returns>
        /// <remarks>
        /// Използва <see cref="ContactmanagerContext"/> за достъп до данните.
        /// </remarks>
        public List<Contact> GetAllContacts()
        {
            
            using (var context = new ContactmanagerContext())
            {
                return contacts;
            }
        }

        /// <summary>
        /// Експортира всички контакти от базата данни в текстов файл на указан път.
        /// </summary>
        /// <param name="filePath">Пътят към текстовия файл, в който ще се запишат данните.</param>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за достъп до базата данни.
        /// Контактите се записват във файл с детайлна информация за всеки контакт.
        /// </remarks>
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

        /// <summary>
        /// Връща списък с контакти, чиито таг съвпада със зададения (без значение от главни/малки букви).
        /// </summary>
        /// <param name="tag">Тагът за търсене.</param>
        /// <returns>Списък с контакти, които имат зададения таг.</returns>
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
