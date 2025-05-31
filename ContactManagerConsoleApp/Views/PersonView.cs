using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager_Graphical.Models;
using ContactManagerConsoleApp.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace ContactManagerConsoleApp.Views
{
    public class PersonView
    {
        private static Services personService = new Services();

        public static void ListAllPeople(Services service)
        {
            var people = service.GetAllPeople();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.SecondName}");
                Console.WriteLine($"  Address: {person.Address}");
                Console.WriteLine($"  BirthDate: {person.BirthDate?.ToString() ?? "N/A"}");

                foreach (var contact in person.Contacts)
                {
                    Console.WriteLine($"  Phone: {contact.PhoneNum}");
                    Console.WriteLine($"  Email: {contact.Email}");
                    Console.WriteLine("  Tags: " + string.Join(", ", contact.Tags.Select(t => t.Name)));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void CreateNewContact(Services service)
        {
            Console.Write(" First name: ");
            var firstName = Console.ReadLine();

            Console.Write(" Second name: ");
            var secondName = Console.ReadLine();

            Console.Write(" Address: ");
            var address = Console.ReadLine();

            DateOnly birthDate;
            while (true)
            {
                Console.Write(" BirthDate (yyyy-MM-dd): ");
                var birthInput = Console.ReadLine();

                if (DateOnly.TryParse(birthInput, out birthDate))
                {
                    break;
                }
                Console.WriteLine(" Invalid date format. Please use yyyy-MM-dd.");
            }

            int phonenum;
            while (true)
            {
                Console.Write(" Phone Number: ");
                var phoneNumInput = Console.ReadLine();

                if (int.TryParse(phoneNumInput, out phonenum))
                {
                    break;
                }
                Console.WriteLine(" Invalid number. Please enter digits only.");
            }

            Console.Write(" Email: ");
            var email = Console.ReadLine();

            Console.Write(" Tags ( ,): ");
            var tagsInput = Console.ReadLine();
            var tagNames = tagsInput.Split(',').Select(t => t.Trim()).ToList();

            Console.WriteLine();

            if (firstName == string.Empty || secondName == string.Empty)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid name!");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }
            if (service.CreateContact(firstName, secondName, address, birthDate, phonenum, email, tagNames))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully created!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Create failed.");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
        public static void UpdatePerson(Services service)
        {
            var people = service.GetAllPeople();
            Console.WriteLine("Write the name of the contact you want to update.");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.SecondName}");
            }

            Console.Write(" First name: ");
            var firstName = Console.ReadLine();

            Console.Write(" Second name: ");
            var secondName = Console.ReadLine();

            Console.Write(" Address: ");
            var address = Console.ReadLine();

            DateOnly birthDate;
            while (true)
            {
                Console.Write(" BirthDate (yyyy-MM-dd): ");
                var birthInput = Console.ReadLine();

                if (DateOnly.TryParse(birthInput, out birthDate))
                {
                    break;
                }
                Console.WriteLine(" Invalid date format. Please use yyyy-MM-dd.");
            }

            int phonenum;
            while (true)
            {
                Console.Write(" Phone Number: ");
                var phoneNumInput = Console.ReadLine();

                if (int.TryParse(phoneNumInput, out phonenum))
                {
                    break;
                }
                Console.WriteLine(" Invalid number. Please enter digits only.");
            }

            Console.Write(" Email: ");
            var email = Console.ReadLine();

            Console.Write(" Tags ( ,): ");
            var tagsInput = Console.ReadLine();
            var tagNames = tagsInput.Split(',').Select(t => t.Trim()).ToList();

            Console.WriteLine();

            if (service.UpdateContact(firstName, secondName, address, birthDate, phonenum, email, tagNames))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully updated!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Update failed. Contact not found.");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
        public static void deletePerson(Services service)
        {
            var people = service.GetAllPeople();
            Console.WriteLine("Write the name of the contact you want to delete.");
            
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.SecondName}");
            }

            Console.Write(" First name: ");
            var firstName = Console.ReadLine();

            Console.Write(" Second name: ");
            var secondName = Console.ReadLine();

            if (service.DeletePerson(firstName, secondName) == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully deleted!");
                Console.ResetColor();
            }
            if (service.DeletePerson(firstName, secondName) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No such person!");
                Console.ResetColor();
            }
            Console.ReadKey();
        }

        /*public static void SearchPerson(Services service)
        {
            Console.WriteLine("Search by name, number or tags:");
            var input = Console.ReadLine();

            if (input != string.Empty)
            {
                service.GetPersonByName(input);
            }
            long number = long.Parse(input);
            if (input == number.ToString())
            {
                service.GetPersonByNum(number);
            }
        }*/
        
    }
}
