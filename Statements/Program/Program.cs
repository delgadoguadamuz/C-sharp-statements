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
                        Console.Clear();
                        break;
                    case 'b':
                        concatenarStrings();
                        Console.Clear();
                        break;
                    case 'c':
                        loopANumber();
                        Console.Clear();
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
                
            }
        }

        private static void loopANumber()
        {

            int value;

            Console.WriteLine("Por favor ingrese un numero");
            Console.ReadLine();
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {

                Console.WriteLine("El valor de i es " + i);

            }

            int u = value;
            while (u > 0)
            {

                Console.WriteLine("El valor de u es" + u);
                u--;
            }

            Console.ReadKey();
           
        }
        

        private static void concatenarStrings()
        {
            Console.WriteLine("Digite un frase");
            Console.ReadLine();
            string frase1 = Console.ReadLine();

            Console.WriteLine("Digite otra frase");
            string frase2 = Console.ReadLine();

            Console.WriteLine("Las frases digitas son :"+ frase1 + frase2);
            Console.ReadLine();
            

        }

        private static void addValues()
        {
           int a,b;
            
            Console.WriteLine("Ingrese un numero:");
            Console.ReadLine();
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingrese otro numero:");
            b = Convert.ToInt32(Console.ReadLine());
           
            int suma = 0;
            suma= a + b;

            Console.WriteLine("La suma de los dos numeros  " + suma);
            Console.ReadLine();
           

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
