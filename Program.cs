using System;

internal class Program
{
    static int limit = 10;
    string[] beerList = new string[limit];
    int iBeer = 0;

    private static void Main(string[] args)
    {
        Program program = new Program();
        int op;

        do
        {
            Console.Clear();
            Console.WriteLine("Hola, elige qué quieres hacer: "); 
            Console.WriteLine("1. Agregar cerveza");
            Console.WriteLine("2. Mostrar lista de cervezas");
            Console.WriteLine("3. Salir");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    program.AgregarCerveza();
                    break;

                case 2:
                    program.MostrarCervezas();
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

        } while (op != 3);
    }

    // Método para agregar una cerveza
    void AgregarCerveza()
    {
        if (iBeer < limit)
        {
            Console.WriteLine("Escribe el nombre de la cerveza: ");
            beerList[iBeer] = Console.ReadLine();
            iBeer++;
            Console.WriteLine("Cerveza agregada. Presiona una tecla para continuar.");
        }
        else
        {
            Console.WriteLine("La lista de cervezas está llena. Presiona una tecla para continuar.");
        }
        Console.ReadKey();
    }

    // Método para mostrar las cervezas
    void MostrarCervezas()
    {
        Console.WriteLine("Lista de cervezas: ");
        for (int i = 0; i < iBeer; i++)
        {
            Console.WriteLine($"{i + 1}. {beerList[i]}");
        }
        if (iBeer == 0)
        {
            Console.WriteLine("No hay cervezas en la lista.");
        }
        Console.WriteLine("Presiona una tecla para continuar.");
        Console.ReadKey();
    }
}