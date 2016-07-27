using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int expression = 7;

            switch (expression)
            {

                case 0:
                case 1:

                    Console.WriteLine("0 o 1");
                    break;
                case 2:

                    Console.WriteLine("2");
                    break;

                case 3:

                    Console.WriteLine("3");
                    break;

                default:
                    Console.WriteLine("Otro Valor");
                    break;

              
            }

            Console.ReadKey();
        }
    }
}
