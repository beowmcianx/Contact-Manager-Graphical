using Contact_Manager_Graphical.Models;
using Contact_Manager_Graphical.Services;
using ContactManagerConsoleApp.Service;
using ContactManagerConsoleApp.Views;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ContactManagerConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Services services = new Services();
            PersonView personView = new PersonView();
            Console.WriteLine("ContactManager\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ts - see contacts");
            Console.WriteLine("\ta - Add Contact");
            Console.WriteLine("\tu - Update Contact");
            Console.WriteLine("\td - Delete");
            Console.Write("Your option? ");








            switch (Console.ReadLine())
            {
                case "a":
                    PersonView.CreateNewContact(services);
                    break;
                case "u":


                    break;
                case "s":
                    ListAllPeople(services);



                    break;
                case "d":

                    break;
            }

            Console.Write("Press any key to close the app...");
            Console.ReadKey();
        }
        static void ListAllPeople(Services service)
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



