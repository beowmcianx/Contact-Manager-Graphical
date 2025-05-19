using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContactManagerConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

           
            Console.WriteLine("ContactManager\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add Contact");
            Console.WriteLine("\tu - Update Contact");
            Console.WriteLine("\ts - see contacts");
            Console.WriteLine("\td - Delete");
            Console.Write("Your option? ");


           

          
           

          
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Type First Name:");
                    Console.ReadLine();
                    Console.WriteLine("Type Second Name:");
                    Console.ReadLine();
                    Console.WriteLine("Type Address:");
                    Console.ReadLine();
                    Console.WriteLine("Type PhoneNum:");
                    Console.ReadLine();
                    Console.WriteLine("Type Email:");
                    Console.ReadLine();
                    Console.WriteLine("Type Date of Birth:");
                    Console.ReadLine();
                    Console.WriteLine("Type Tag:");
                    Console.ReadLine();
                    break;
                case "u":
                    Console.WriteLine($"Updte First name:");
                    Console.ReadLine();
                    Console.WriteLine($"Updte Second name:");
                    Console.ReadLine();
                    Console.WriteLine($"Updte Address:");
                    Console.ReadLine();
                    Console.WriteLine($"Updte PhoneNum:");
                    Console.ReadLine();
                    Console.WriteLine($"Updte Email:");
                    Console.ReadLine();
                    Console.WriteLine($"Updte Date of Birth:");
                    Console.ReadLine();
                    Console.WriteLine($"Updte Tag:");
                    Console.ReadLine();

                    break;
                case "m":
                    Console.WriteLine($"All contacts ");
                    break;
                case "d":
                    Console.WriteLine($"Type contact name to delete" );
                    Console.ReadLine();
                    Console.WriteLine($"Type contact Number to delete");
                    Console.ReadLine();
                    break;
            }
     
            Console.Write("Press any key to close the app...");
            Console.ReadKey();
        }
    }
}
