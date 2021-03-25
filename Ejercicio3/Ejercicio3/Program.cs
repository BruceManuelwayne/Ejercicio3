using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.WriteLine("ingrese una tecla, x para terminar");
            var input = Console.ReadKey();
          
            do
            {
                
                cki = Console.ReadKey();
                Console.WriteLine(cki.Key.ToString()); 
            } while (cki.Key != ConsoleKey.X); 
           
            
            //porque en la consola me muestra dos letras? 
        }
    }
}
