using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager_Graphical.Models;
using ContactManagerConsoleApp.Service;
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
    }
}
