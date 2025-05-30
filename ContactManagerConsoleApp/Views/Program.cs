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
            while (true)
            {
                Services services = new Services();
                PersonView personView = new PersonView();
                Console.WriteLine("ContactManager\r");
                Console.WriteLine("------------------------\n");

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ts - See contacts");
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
                        PersonView.ListAllPeople(services);
                        break;
                    case "d":
                        PersonView.DeletePerson(services);
                        break;
                }
                Console.Clear();
            }
        }
        

     
    }


}



