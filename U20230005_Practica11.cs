using System;
using System.ComponentModel;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Menu();
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("\nPrograma que almacena 5 numeros cualquiera en un arreglo...");
                        //int numero = Convert.ToInt32(Console.ReadLine());
                        Numeros();
                        break;

                    case 2:
                        Console.WriteLine("\nPrograma que realiza una suma total de los numeros almazenados en un arreglo...");
                        int sum = Sumando();
                        Console.WriteLine("La suam de los numeros es: " + sum);
                        Sumando();
                        break;

                    case 3:
                        Console.WriteLine("\nPrograma que realiza una suma total de los numeros almazenados en un arreglo...");
                        searchNums();
                        break;

                    case 4:
                        Console.WriteLine("\nPrograma que organiza los numeros de manera ascendente...");
                        organizeNums();
                        break;

                    case 5:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Ingresa uns opcion valida....");
                        break;
                }
            } while (opcion != 5);

        }//Fin del main

        static void Menu()
        {
            Console.WriteLine("\n**********************Menu Principal**********************");
            Console.WriteLine("1. Ingresar numeros:");
            Console.WriteLine("2. Calcular suma e numeros: ");
            Console.WriteLine("3. Buscar número: ");
            Console.WriteLine("4. Ordenar numeros: ");
            Console.WriteLine("5. Salir del menu....");
            Console.WriteLine("**********************Fin del Menu Principal**********************");
            Console.WriteLine("Selecciona una opcion (1 - 5): ");
        }

        //Arrelglo para almacenar los numeros.
        
        static int[] numeros = new int[5];
        static int NumerosDigitados = 0;

        static void Numeros()
        {
            Console.WriteLine("Ingresa hasta 5 numeros (ingresa  -1 para finalizar):");
            NumerosDigitados = 0;

            while(NumerosDigitados < numeros.Length)
            {
                Console.WriteLine("Numero #{0}: ", NumerosDigitados + 1);
                int Numero = Convert.ToInt32(Console.ReadLine());

                if(Numero == -1)
                    break;
                
                numeros[NumerosDigitados] = Numero;
                NumerosDigitados++;

                Console.WriteLine($"\nNumeros ingresados hasta ahora: {NumerosDigitados}\n");

                if(NumerosDigitados == numeros.Length)
                Console.WriteLine($"Has ingresado un total de {NumerosDigitados} numeros.");
            }
        }

        static int Sumando()
        {
            int sumaTotal = 0;
            for(int i = 0; i < NumerosDigitados; i++)
            {
                sumaTotal  += numeros[i];
            }

            return sumaTotal;
        }

        static void searchNums()
        {
            Console.WriteLine("Ingresar el numero a ser buscado: ");
            int numtoSearch = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for(int i = 0; i < NumerosDigitados; i++)
            {
                if(numeros[i] == numtoSearch)
                {
                    found = true;
                    break;
                }
            }
            if(found)
                {
                    Console.WriteLine($"\n El numero {numtoSearch} fue encontrado en el arreglo.");
                }
            else
                {
                    Console.WriteLine($"\n El numero {numtoSearch} no fue encontrado en el arreglo.");
                }  
        }

        static void organizeNums()
        {
            Array.Sort(numeros, 0, NumerosDigitados);
            Console.WriteLine("Numeros ordenados ascendente: ");
            for(int i = 0; i < NumerosDigitados; i++)
            {
                Console.WriteLine(numeros[i]);                
            }
        }

    }
}