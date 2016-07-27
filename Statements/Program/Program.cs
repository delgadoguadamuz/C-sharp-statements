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
                        Console.WriteLine("Cierre de sistema");
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
           int a,b,c;
            
            Console.WriteLine("Ingrese un numero:\n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Ingrese otro numero:\n");
            b = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            c = (a + b);
            Console.WriteLine("La suma de los dos numeros  " + c);
            Console.ReadKey();
            

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
