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
            
            CharController controller = new CharController();

            try
            {
                Console.WriteLine(controller.getSecuence("hi"));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
