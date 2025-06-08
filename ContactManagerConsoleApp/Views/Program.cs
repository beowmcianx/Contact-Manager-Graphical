using Contact_Manager_Graphical.Models;
using Contact_Manager_Graphical.Services;
using ContactManagerConsoleApp.Service;
using ContactManagerConsoleApp.Views;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace ContactManagerConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Services services = new Services();
            PersonView personView = new PersonView();

            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8; // Add this once at the start of Main()

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" ┌──────────────────────────────┐");
                Console.WriteLine(" │ C O N T A C T  M A N A G E R │");
                Console.WriteLine(" └──────────────────────────────┘");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Choose an option from the following list");
                Console.WriteLine(" ┌──────────────────────────────┐");
                Console.WriteLine(" │  V - View Contact            │");
                Console.WriteLine(" │  A - Add Contact             │");
                Console.WriteLine(" │  U - Update Contact          │");
                Console.WriteLine(" │  D - Delete Contact          │");
                Console.WriteLine(" │  S - Search by name or num   │");
                Console.WriteLine(" │  E - Export people to .txt   │");
                Console.WriteLine(" └──────────────────────────────┘");
                Console.Write(" Your option? ");

                switch (Console.ReadLine().ToLower())
                {
                    case "v":
                        Console.WriteLine();
                        Console.WriteLine();
                        PersonView.ListAllPeople(services);
                        break;
                    case "a":
                        Console.WriteLine();
                        Console.WriteLine();
                        PersonView.CreateNewContact(services);
                        break;
                    case "u":
                        Console.WriteLine();
                        Console.WriteLine();
                        PersonView.UpdatePerson(services);
                        break;
                    case "d":
                        Console.WriteLine();
                        Console.WriteLine();
                        PersonView.deletePerson(services);
                        break;
                    case "s":
                        Console.WriteLine();
                        PersonView.SearchPerson(services);
                        break;
                    case "e":
                        Console.WriteLine();
                        PersonView.ExportToTxt(services);
                        break;
                }
                Console.Write("Press any key to close the app...");
                Console.Clear();
            }
        }
    }
}



