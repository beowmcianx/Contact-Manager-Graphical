using Contact_Manager_Graphical.Models;
using Contact_Manager_Graphical.Services;
using ContactManagerConsoleApp.Bussiness_Layer;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ContactManagerConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
        
           Services services = new Services();
           
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
                    CreateNewContact(services);
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

        static void CreateNewContact(Services service)
        {

            Console.Write("First Name: ");
            var firstName = Console.ReadLine();

            Console.Write("Second Name: ");
            var secondName = Console.ReadLine();
            using (var context = new ContactmanagerContext())
            {
                var person = context.People
                      .Include(c => c.Contacts)
                      .ThenInclude(c => c.Tags)
                      .FirstOrDefault(p => p.FirstName == firstName && p.SecondName == secondName);


                Console.Write("Address: ");
                var address = Console.ReadLine();

                Console.Write("BirthDate (yyyy-MM-dd): ");
                var birthDate = Console.ReadLine();
               


                Console.Write("Phone Number: ");
                var phoneNum = Console.ReadLine();
                

                Console.Write("Email: ");
                var email = Console.ReadLine();

                Console.Write("Tags ( ,): ");
                var tagsInput = Console.ReadLine();
                var selectedTags = tagsInput;
                List<Tag> selectedTagNames = new List<Tag>();
                foreach (var tag in selectedTags)
                {
                    selectedTagNames.Add(service.GetTagByName(tag.ToString()));
                }



                person.FirstName = firstName;
                person.SecondName = secondName;
                person.Address = address;
                person.BirthDate = birthDate != "" ? DateOnly.Parse(birthDate) : null;



                var contact = person.Contacts.FirstOrDefault();

                contact.PhoneNum = long.Parse(phoneNum);
                contact.Email = email;
                context.SaveChanges();

                Console.WriteLine("Contact created. Press any key to continue...");
                Console.ReadKey();
                
            }
        }


       
    }
}

