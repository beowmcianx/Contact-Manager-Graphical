﻿using Contact_Manager_Graphical.Models;
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

        // Добавяне на нова личност
        public void AddPerson(Person person)
        {
            
            using (var context = new ContactmanagerContext())
            {
               persons.Add(person);
            }
        }

        // Обновяване на съществуваща личност
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

        // Изтриване на личност
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

        // Намиране на личност по ID
        public Person GetPersonById(int personId)
        {
           
            using (var context = new ContactmanagerContext())
            {
              return persons.FirstOrDefault(p => p.PersonId == personId);
            }
        }

        // Намиране на всички личности
        public List<Person> GetAllPersons()
        {
           
            using (var context = new ContactmanagerContext())
            {
              return persons;
            }
        }

        // Намиране на личности по първо или второ име
        public List<Person> GetPersonsByName(string name)
        {
            using (var context = new ContactmanagerContext())
            {
              return persons.Where(p => p.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase) || p.LastName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
     
            }
              }

        // Намиране на всички хора, родени през определена година
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
