using Contact_Manager_Graphical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Graphical.Services
{
    public class PersonService
    {
        private List<Person> persons;

        public PersonService()
        {
            
            using (var context = new ContactmanagerContext())
            {
             persons = new List<Person>();
            }
        }

        /// <summary>
        /// Добавя нов обект от тип <see cref="Person"/> към базата данни.
        /// </summary>
        /// <param name="person">Обект от тип <see cref="Person"/>, съдържащ информацията за добавяне.</param>
        /// <remarks>
        /// Методът създава нов екземпляр на <see cref="ContactmanagerContext"/>, 
        /// добавя лицето и записва промените в базата данни.
        /// </remarks>

        public void AddPerson(Person person)
        {
            
            using (var context = new ContactmanagerContext())
            {
               persons.Add(person);
            }
        }

        /// <summary>
        /// Актуализира съществуващ обект <see cref="Person"/> по неговото ID.
        /// </summary>
        /// <param name="personId">Уникалният идентификатор на лицето за актуализация.</param>
        /// <param name="updatedPerson">Обект с новите данни, които трябва да се приложат.</param>
        /// <returns>
        /// Връща <c>true</c>, ако лицето е намерено и актуализирано успешно; 
        /// в противен случай връща <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за достъп до базата данни.
        /// Промените се записват чрез <c>context.SaveChanges()</c>.
        /// </remarks>
        public bool UpdatePerson(int personId, Person updatedPerson)
        {
            
            using (var context = new ContactmanagerContext())
            {
              var person = persons.FirstOrDefault(p => p.PersonId == personId);
             if (person != null)
             {
                person.FirstName = updatedPerson.FirstName;
                person.LastName = updatedPerson.LastName;
                person.BirthDate = updatedPerson.BirthDate;
                person.Email = updatedPerson.Email;
                person.Phone = updatedPerson.Phone;
                return true;
             }
            return false;
            }
        }

        /// <summary>
        /// Изтрива обект <see cref="Person"/> от базата данни по зададено ID.
        /// </summary>
        /// <param name="personId">Уникалният идентификатор на лицето за изтриване.</param>
        /// <returns>
        /// Връща <c>true</c>, ако лицето е намерено и успешно изтрито; 
        /// в противен случай връща <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за достъп до базата данни.
        /// Промените се записват чрез <c>context.SaveChanges()</c>.
        /// </remarks>
        public bool DeletePerson(int personId)
        {
            
            using (var context = new ContactmanagerContext())
            {
               var person = persons.FirstOrDefault(p => p.PersonId == personId);
             if (person != null)
             {
                 persons.Remove(person);
                 return true;
             }
             return false;
            }
        }

        /// <summary>
        /// Връща обект <see cref="Person"/> от базата данни по зададеното ID.
        /// </summary>
        /// <param name="personId">Уникалният идентификатор на лицето, което се търси.</param>
        /// <returns>
        /// Обект от тип <see cref="Person"/>, ако е намерен; 
        /// в противен случай връща <c>null</c>.
        /// </returns>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за достъп до базата данни.
        /// </remarks>
        public Person GetPersonById(int personId)
        {
           
            using (var context = new ContactmanagerContext())
            {
              return persons.FirstOrDefault(p => p.PersonId == personId);
            }
        }

        /// <summary>
        /// Извлича списък с всички обекти <see cref="Person"/> от базата данни.
        /// </summary>
        /// <returns>
        /// Списък от тип <see cref="List{Person}"/> с всички съхранени лица.
        /// </returns>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> за достъп до базата данни.
        /// </remarks>
        public List<Person> GetAllPersons()
        {
           
            using (var context = new ContactmanagerContext())
            {
              return persons;
            }
        }

        /// <summary>
        /// Извлича списък от обекти <see cref="Person"/>, чието собствено или фамилно име съдържа зададен текст.
        /// </summary>
        /// <param name="name">Част от името или фамилията за търсене (без значение за главни/малки букви).</param>
        /// <returns>
        /// Списък от обекти <see cref="Person"/>, които отговарят на зададеното търсене.
        /// </returns>
        /// <remarks>
        /// Търсенето е нечувствително към големи и малки букви, като се използва <c>ToLower()</c>.
        /// </remarks>
        public List<Person> GetPersonsByName(string name)
        {
            using (var context = new ContactmanagerContext())
            {
              return persons.Where(p => p.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase) || p.LastName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
     
            }
        }

        /// <summary>
        /// Извлича списък от обекти <see cref="Person"/>, родени през зададена година.
        /// </summary>
        /// <param name="year">Годината на раждане, по която се извършва филтрация.</param>
        /// <returns>
        /// Списък от обекти <see cref="Person"/>, родени през съответната година.
        /// </returns>
        /// <remarks>
        /// Методът използва <see cref="ContactmanagerContext"/> и LINQ към Entity Framework.
        /// </remarks>
        public List<Person> GetPersonsByBirthYear(int year)
        {
            using (var context = new ContactmanagerContext())
            {
             return persons.Where(p => p.BirthDate.Year == year).ToList();
           
            }
        }

        
       
    }

    // Модел на личност
    public class Person
    {
        public int PersonId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
      
        public string Email { get; set; }
        public string Phone { get; set; }

        public Person(int personId, string firstName, string lastName, DateTime birthDate,  string email, string phone)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
        }
    }
}
