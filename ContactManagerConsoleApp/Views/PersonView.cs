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
        public static void CreateNewContact(Services service)
        {

            Console.Write("First Name: ");
            var firstName = Console.ReadLine();

            Console.Write("Second Name: ");
            var secondName = Console.ReadLine();



            Console.Write("Address: ");
            var address = Console.ReadLine();

            Console.Write("BirthDate (yyyy-MM-dd): ");
            var birthDate = DateOnly.Parse(Console.ReadLine());



            Console.Write("Phone Number: ");
            var phoneNumInput = Console.ReadLine();
            var phonenum = int.Parse(phoneNumInput);


            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Tags ( ,): ");
            var tagsInput = Console.ReadLine();
            var tagNames = tagsInput.Split(',').Select(t => t.Trim()).ToList();

            if (service.CreateContact(firstName, secondName, address, birthDate, phonenum, email, tagNames) == true)
            {
                Console.WriteLine("Successfully added!");
            }


            Console.WriteLine("Contact created. Press any key to continue...");
            Console.ReadKey();



        }
        public static void DeletePerson(Services service)
        {
            Console.WriteLine("Person to delete:");
            Console.Write("First name:");
            string FirstName = Console.ReadLine();
            Console.Write("Last name:");
            string LastName = Console.ReadLine();

            if (service.Delete(FirstName,LastName) == true)
            {
                Console.WriteLine("Successfully deleted!");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

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

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
