using Ejercicios.TresEnRaya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ejercicios
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de Ejercicios");
            Console.WriteLine("Seleccione el ejercicio al que quiere acceder");

            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    new Juego();
                    break;
                default:
                    
                    break;
            }
        }
    }
}
