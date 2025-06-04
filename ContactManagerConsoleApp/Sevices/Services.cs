using Contact_Manager_Graphical.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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

        /// <summary>
        /// Връща обект <see cref="Tag"/> от базата данни по зададено име.
        /// </summary>
        /// <param name="name">Името на търсения таг.</param>
        /// <returns>
        /// Обект <see cref="Tag"/>, ако е намерен; в противен случай <c>null</c>.
        /// </returns>
        /// <remarks>
        /// Използва <see cref="ContactmanagerContext"/> за търсене на таг с точно съвпадение на името.
        /// Търсенето е чувствително към регистъра (главни/малки букви).
        /// </remarks>
        public Tag GetTagByName(string name)
        {
            using (var context = new ContactmanagerContext())
            {
                return context.Tags.FirstOrDefault(t => t.Name == name);
            }

        }

        /// <summary>
        /// Връща списък с всички хора от базата данни, включително техните контакти и тагове.
        /// </summary>
        /// <returns>
        /// Списък от обекти <see cref="Person"/>, включващ свързаните колекции от <see cref="Contact"/> и <see cref="Tag"/>.
        /// </returns>
        /// <remarks>
        /// Използва <see cref="Include"/> и <see cref="ThenInclude"/> за eager loading на навигационните свойства.
        /// Това предотвратява допълнителни заявки към базата при достъп до <c>Contacts</c> и <c>Tags</c>.
        /// </remarks>
        public List<Person> GetAllPeople()
        {
            return context.People
                 .Include(p => p.Contacts)
                 .ThenInclude(c => c.Tags)
                 .ToList();
        }

        public void ExportSystem()
        {
            Directory.CreateDirectory("export");
            string filePath = "export/exportConsole.txt";
            var content = "";

            using (var context = new ContactmanagerContext())
            {
                var people = context.People
                    .Include(p => p.Contacts)
                    .ToList();

                foreach (var person in people)
                {
                    string fullName = $"{person.FirstName} {person.SecondName}";
                    foreach (var contact in person.Contacts)
                    {
                        content += $"{fullName} | Phone: {contact.PhoneNum}\n";
                    }
                }
            }
            File.WriteAllText(filePath, content);
        }

        public void GetPersonByName(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return;
            searchTerm = searchTerm.ToLower();

            var filtered = context.People
                .Include(p => p.Contacts)
                .ThenInclude(c => c.Tags)
                .Where(p => (p.FirstName + " " + p.SecondName).ToLower().Contains(searchTerm) ||
                    p.Contacts.Any(c =>
                        c.PhoneNum.ToString().Contains(searchTerm) ||
                        c.Tags.Any(t => t.Name.ToLower().Contains(searchTerm))))
                .ToList();

            foreach (var person in filtered)
            {
                Console.WriteLine($"  {person.FirstName} {person.SecondName}");
            }
        }


        /// <summary>
        /// Намира и връща обект <see cref="Person"/>, свързан с контакт, който има зададения телефонен номер.
        /// </summary>
        /// <param name="num">Телефонният номер, по който се търси.</param>
        /// <returns>
        /// Обект <see cref="Person"/> ако е намерен, или <c>null</c> ако няма съвпадение.
        /// </returns>
        /// <remarks>
        /// Извлича свързаните контакти и техните тагове чрез <see cref="Include"/> и <see cref="ThenInclude"/>.
        /// </remarks>

        public Person? GetPersonByNum(long num)
        {
            return context.Contacts
                .Include(c => c.Person)
                .ThenInclude(p => p.Contacts)
                .ThenInclude(c => c.Tags)
                .Where(c => c.PhoneNum == num)
                .Select(c => c.Person)
                .FirstOrDefault();
        }

        /// <summary>
        /// Създава нов контакт и свързан човек, ако такъв с даденото име и презиме не съществува.
        /// </summary>
        /// <param name="firstName">Собственото име на лицето.</param>
        /// <param name="secondName">Фамилията на лицето.</param>
        /// <param name="address">Адресът на лицето.</param>
        /// <param name="birthDate">Дата на раждане на лицето.</param>
        /// <param name="phoneNum">Телефонен номер на контакта.</param>
        /// <param name="email">Имейл на контакта.</param>
        /// <param name="tagNames">Списък с имена на тагове, които да се асоциират с контакта.</param>
        /// <returns>
        /// <c>true</c> ако контактът е успешно създаден; <c>false</c> ако човек с тези имена вече съществува.
        /// </returns>
        /// <remarks>
        /// Създава нов обект <see cref="Person"/> с един <see cref="Contact"/> и зададените тагове.
        /// Ако таг не съществува в базата, той се създава автоматично.
        /// Проверява се уникалност на човек по собствено и фамилно име.
        /// </remarks>
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
        /// <summary>
        /// Изтрива лице (Person) от базата данни заедно с неговите контакти и връзки с тагове.
        /// </summary>
        /// <param name="firstName">Собственото име на лицето, което ще бъде изтрито.</param>
        /// <param name="secondName">Фамилията на лицето, което ще бъде изтрито.</param>
        /// <returns>
        /// <c>true</c>, ако лицето е успешно намерено и изтрито; <c>false</c>, ако такова лице не съществува.
        /// </returns>
        /// <remarks>
        /// Преди да бъдат изтрити контактите, всички връзки с тагове се премахват чрез <see cref="List{T}.Clear"/>.
        /// След това се изтриват самите контакти, и накрая — самият човек.
        /// Извършва се поетапно записване на промените с <see cref="DbContext.SaveChanges"/>.
        /// </remarks>

        public bool DeletePerson(string firstName, string secondName)
        {
            using var context = new ContactmanagerContext();


            var person = context.People.FirstOrDefault(p => p.FirstName == firstName && p.SecondName == secondName);
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

        /// <summary>
        /// Актуализира информацията за дадено лице и неговия контакт, включително списъка с тагове.
        /// </summary>
        /// <param name="firstName">Собственото име на лицето, което ще бъде актуализирано.</param>
        /// <param name="secondName">Фамилията на лицето.</param>
        /// <param name="address">Новият адрес.</param>
        /// <param name="birthDate">Новата дата на раждане.</param>
        /// <param name="phoneNum">Нов телефонен номер за контакт.</param>
        /// <param name="email">Нов имейл адрес.</param>
        /// <param name="tagNames">Списък с новите имена на тагове, които да се асоциират с контакта.</param>
        /// <returns>
        /// Връща <c>true</c>, ако лицето е намерено и успешно актуализирано; <c>false</c>, ако не е намерено.
        /// </returns>
        /// <remarks>
        /// Методът търси лице по собствено и фамилно име. Ако бъде намерено, актуализира неговите основни данни,
        /// както и първия свързан контакт. Предишните тагове на контакта се изчистват и заменят с нови,
        /// като липсващите тагове се създават в базата.
        /// </remarks>

        public bool UpdateContact( int id,string address, DateOnly birthDate, long phoneNum, string email, List<string> tagNames)
        {
            var existingPerson = context.People
                   .Include(c => c.Contacts)
                   .ThenInclude(c => c.Tags)
                   .FirstOrDefault(p => p.FirstName == p.FirstName && p.SecondName == p.SecondName);

            if (existingPerson == null)
            {
                return false;
            }

            existingPerson.PersonId = id;
         
            existingPerson.Address = address;
            if (address == string.Empty)
            {
                address = existingPerson.Address;
            }
            existingPerson.BirthDate = birthDate;
             
            if (birthDate <= 0)
            {
                birthDate = person.BirthDate?.ToString() ?? "";
            }
            var contact = existingPerson.Contacts.FirstOrDefault();
            if (contact != null)
            {

                if (long.TryParse(ReadOnlySpan.Parse(phoneNum), out var newPhoneNum))
                    contact.PhoneNum = newPhoneNum;
                if (email == string.Empty)
                {
                    email = contact.Email;
                }
                contact.Email = email;


                contact.Tags.Clear();


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

            }
            context.SaveChanges();
            return true;
        }

    }
}






