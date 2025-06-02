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

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("C O N T A C T   M A N A G E R\r");
                Console.ResetColor();
                Console.WriteLine("-----------------------------\n");

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\tV - View contacts");
                Console.WriteLine("\tA - Add Contact");
                Console.WriteLine("\tU - Update Contact");
                Console.WriteLine("\tD - Delete");
                Console.WriteLine("\tS - Search by name or num"); 
                Console.WriteLine("\tE - Export people to .txt");
                Console.Write("Your option? ");

                switch (Console.ReadLine().ToLower())
                {
                    case "v":
                        Console.WriteLine();
                        PersonView.ListAllPeople(services);
                        break;
                    case "a":
                        Console.WriteLine();
                        PersonView.CreateNewContact(services);
                        break;
                    case "u":
                        Console.WriteLine();
                        PersonView.UpdatePerson(services);
                        break;
                    case "d":
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



