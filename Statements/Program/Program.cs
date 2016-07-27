using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            while (proceed)
            {
                char selecction =printMenu();
                switch (selecction)
                {
                    case 'a':
                        addValues();
                        break;
                    case 'b':
                        concatenarStrings();
                        break;
                    case 'c':
                        loopANumber();
                        break;
                    case 'd':
                        proceed = false;
                        Console.WriteLine("bye bye");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;

                }
                break;   
            }
        }

        private static void loopANumber()
        {
            throw new NotImplementedException();
        }

        private static void concatenarStrings()
        {
            throw new NotImplementedException();
        }

        private static void addValues()
        {
            throw new NotImplementedException();
        }

        static char printMenu()
        {
            Console.WriteLine("Seleccione una opcion\n");
            Console.WriteLine("a- Sumar dos valores\n");
            Console.WriteLine("b- Concatenar dos Strings\n");
            Console.WriteLine("c- Iterar un numero\n");
            Console.WriteLine("d- Salir\n");
            char option = (char)Console.Read();
            return option;

        }

    }
}
