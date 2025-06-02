using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager_Graphical.Models;
using ContactManagerConsoleApp.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace ContactManagerConsoleApp.Views
{
    public class PersonView
    {
        private static Services personService = new Services();

        /// <summary>
        /// Извежда в конзолата списък с всички хора, включително техните адреси, рождени дати, контакти и тагове.
        /// </summary>
        /// <param name="service">Инстанция на <see cref="Services"/>, чрез която се извлича списъкът с хора.</param>
        /// <remarks>
        /// За всеки човек се показват името, адресът и рождената дата.
        /// За всеки свързан контакт се извеждат телефонен номер, имейл и списък с тагове.
        /// След показването на информацията, методът изчаква натискане на клавиш чрез <see cref="Console.ReadKey"/>.
        /// </remarks>

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

        /// <summary>
        /// Интерктивно събира информация от потребителя в конзолата и създава нов контакт чрез предоставения <see cref="Services"/> обект.
        /// </summary>
        /// <param name="service">Инстанция на <see cref="Services"/>, използвана за създаване на нов контакт.</param>
        /// <remarks>
        /// Методът прочита данни като собствено и фамилно име, адрес, дата на раждане, телефонен номер, имейл и тагове.
        /// Валидира датата на раждане и телефонния номер чрез цикли, които повтарят искането при грешен формат.
        /// Ако имената са празни, изписва съобщение за грешка и прекратява изпълнението.
        /// При успешно създаване на контакт показва зелено съобщение, при неуспех — червено.
        /// Изчаква натискане на клавиш преди да приключи.
        /// </remarks>

        public static void ExportToTxt(Services service)
        {
            service.ExportSystem();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfully exported to .txt!");
            Console.ResetColor();
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


        /// <summary>
        /// Позволява на потребителя интерактивно да актуализира информацията за съществуващ контакт.
        /// </summary>
        /// <param name="service">Инстанция на <see cref="Services"/>, използвана за извличане и актуализиране на контактите.</param>
        /// <remarks>
        /// Методът първо извежда списък с всички налични хора, след което приема вход от конзолата за обновяване на данни като:
        /// собствено и фамилно име, адрес, дата на раждане, телефонен номер, имейл и тагове.
        /// Валидира формата на датата и телефонния номер, като изисква корекция при грешка.
        /// Ако актуализацията е успешна, показва зелено съобщение, при неуспех — червено.
        /// Изчаква натискане на клавиш преди да приключи.
        /// </remarks>

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

        /// <summary>
        /// Позволява на потребителя интерактивно да изтрие съществуващ човек от списъка чрез въвеждане на собствено и фамилно име.
        /// </summary>
        /// <param name="service">Инстанция на <see cref="Services"/>, използвана за извличане на хора и изтриване на избрания.</param>
        /// <remarks>
        /// Методът извежда списък с всички хора, след което приема вход за собствено и фамилно име.
        /// Ако човекът бъде намерен и изтрит успешно, се показва зелено съобщение.
        /// Ако човекът не съществува, се показва червено съобщение.
        /// Методът изчаква натискане на клавиш преди да приключи.
        /// </remarks>

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
                Console.ReadKey();
                return;
            }
            if (service.DeletePerson(firstName, secondName) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No such person!");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }
        }

        public static void SearchPerson(Services service)
        {
            Console.Write("Search by Name, Number or Tag: ");
            var term = Console.ReadLine();
            
            service.GetPersonByName(term);

            Console.ReadKey();
        }

    }
}
