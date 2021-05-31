using System;
using Telefono_App.Models;
using Telefono_App.Controllers;
using System.Collections.Generic;

namespace Telefono_App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CharController controller = new CharController();
                menu(controller);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} Exiting...\n");
            }
        }

        static void menu(CharController controller)
        {
            string input = "";
            while(true)
            {
                Console.Clear();
                Console.WriteLine("=============[]=============");
                Console.WriteLine("Frase a convertir: ");
                input = Console.ReadLine();
                if (input == "-q") break;
                controller.getSecuence(input);
                Console.WriteLine("Presiona cualquier tecla para continuar");
                Console.ReadLine();
            }
            Console.WriteLine(". . . Bye !");
        }
    }
}
