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

        public static void PressAnyKey()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("┌──────────────────────────────┐");
            Console.WriteLine("│ Press any key to continue... │");
            Console.WriteLine("└──────────────────────────────┘");
            Console.ResetColor();
            Console.ReadKey();
        }
        public static void Box(string i, ConsoleColor u)
        {
            Console.ForegroundColor = u;
            Console.WriteLine();
            Console.Write("┌");
            for (int j = 0; j < i.Length + 2; j++)
            {
                Console.Write("─");
            }
            Console.WriteLine("┐");

            Console.WriteLine($"│ {i} │");

            Console.Write("└");
            for (int j = 0; j < i.Length + 2; j++)
            {
                Console.Write("─");
            }
            Console.WriteLine("┘");

            Console.ResetColor();
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

            PressAnyKey();
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

            Box("Succesfully exported to .txt!", ConsoleColor.Green);
            PressAnyKey();
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Invalid date format. Please use yyyy-MM-dd.");
                Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Invalid number. Please enter digits only.");
                Console.ResetColor();
            }

            Console.Write(" Email: ");
            var email = Console.ReadLine();

            Console.Write(" Tags ( ,): ");
            var tagsInput = Console.ReadLine();
            var tagNames = tagsInput.Split(',').Select(t => t.Trim()).ToList();

            Console.WriteLine();

            if (firstName == string.Empty || secondName == string.Empty)
            {
                Box("Invalid Name! Creation failed.", ConsoleColor.Red); 
                PressAnyKey();
                return;
            }
            if (service.CreateContact(firstName, secondName, address, birthDate, phonenum, email, tagNames))
            {
                Box("Successfully created!", ConsoleColor.Green);
            }
            else
            {
                Box("Creation failed.", ConsoleColor.Red);
            }
            PressAnyKey();
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
            Console.WriteLine("Enter the ID of the contact you want to update.");
            var people = service.GetAllPeople();

            foreach (var person in people)
            {
                Console.WriteLine($" [{person.PersonId}] {person.FirstName} {person.SecondName}");
            }

            Console.WriteLine();

            while (true)
            {
                Console.Write(" Your choice: ");
                if (!int.TryParse(Console.ReadLine(), out var id))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid ID format. Please enter a number.");
                    Console.ResetColor();
                    continue;
                }

                var selectedPerson = people.FirstOrDefault(p => p.PersonId == id);
                if (selectedPerson == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" No contact with such ID found.");
                    Console.ResetColor();
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Leave the fields you don't want to change empty.");
                Console.ResetColor();

                Console.Write(" Address: ");
                var address = Console.ReadLine();

                Console.Write(" BirthDate (yyyy-MM-dd): ");
                var birthInput = Console.ReadLine();
                if (DateOnly.TryParse(birthInput, out var parsedDate))
                    birthInput = parsedDate.ToString("yyyy-MM-dd");

                Console.Write(" Phone Number: ");
                var phoneNumInput = Console.ReadLine();
                if (long.TryParse(phoneNumInput, out var parsedPhone))
                    phoneNumInput = parsedPhone.ToString();

                Console.Write(" Email: ");
                var email = Console.ReadLine();

                Console.Write(" Tags ( ,): ");
                var tagsInput = Console.ReadLine();
                var tagNames = tagsInput.Split(',').Select(t => t.Trim()).ToList();

                
                service.UpdateContact(id, address, birthInput, phoneNumInput, email, tagNames);

                Box("Contact updated (if changes were provided).", ConsoleColor.Green);
                PressAnyKey();
                break;
            }
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
            Console.WriteLine("Write the ID of the contact you want to delete.");
            Console.WriteLine(" [0] Exit menu");

            foreach (var person in people)
            {
                Console.WriteLine($" [{person.PersonId}] {person.FirstName} {person.SecondName}");
            }

            Console.WriteLine();

            while (true)
            {
                Console.Write(" Your choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out var id))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid ID format. Please enter a number.");
                    Console.ResetColor();
                    continue;
                }

                if (id == 0)
                {
                    PressAnyKey();
                    return;
                }

                if (service.DeletePerson(id))
                {
                    Box("Successfully deleted!", ConsoleColor.Green);;
                }
                else
                {
                    Box("No such person!", ConsoleColor.Red); ;
                }
                PressAnyKey();
                return;
            }
        }


        public static void SearchPerson(Services service)
        {
            Console.Write("Search by Name, Number or Tag: ");
            var term = Console.ReadLine();

            service.GetPersonByName(term);

            PressAnyKey();
        }

    }
}
