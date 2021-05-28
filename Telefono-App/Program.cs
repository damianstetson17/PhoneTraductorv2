using System;
using Telefono_App.Controllers;
namespace Telefono_App
{
    class Program
    {
        static void Main(string[] args)
        {
            CharController controller = new CharController();

            try
            {
                controller.getSecuence("");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
