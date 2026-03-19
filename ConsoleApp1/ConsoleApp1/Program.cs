namespace ConsoleApp1
{
    internal class Program
    {
        static Libro[] libros = new Libro[100];
        static int contador = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Añadir libro");
                Console.WriteLine("2. Listar libros");
                Console.WriteLine("3. Buscar libro por título");
                Console.WriteLine("4. Marcar libro como prestado");
                Console.WriteLine("5. Marcar libro como devuelto");
                Console.WriteLine("6. Mostrar libros prestados");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AñadirLibro();
                        break;
                    case 2:
                        ListarLibros();
                        break;
                    case 3:
                        BuscarLibro();
                        break;
                    case 4:
                        PersonaB.MarcarPrestado();
                        break;
                    case 5:
                        PersonaB.MarcarDevuelto();
                        break;
                    case 6:
                        PersonaB.MostrarPrestados();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            } while (opcion != 0);
        }
       
    }
}
