using System.Collections;
namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            IniciarBiblioteca();
        }

        // Métodos (puedes implementarlos aparte según la división del trabajo)

        static List <Libro>libros = new List<Libro>();
        static int contador = 0;
        public static void IniciarBiblioteca()
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
                        MarcarPrestado();
                        break;
                    case 5:
                        MarcarDevuelto();
                        break;
                    case 6:
                        MostrarPrestados();
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
        static void AñadirLibro()
        {
            Console.WriteLine("Función añadir libro");
        }

        static void ListarLibros()
        {
            Console.WriteLine("Función listar libros");
        }

        static void BuscarLibro()
        {
            Console.WriteLine("Función buscar libro");
        }

        static void MarcarPrestado()
        {
            Console.WriteLine("Función marcar como prestado");            
            Console.Write("Que libro quieres prestar: ");
            int numero_libro = int.Parse(Console.ReadLine());
            libros[numero_libro].estado = "prestado";
        }

        static void MarcarDevuelto()
        {
            Console.WriteLine("Función marcar como devuelto");
            Console.Write("Que libro quieres devolver: ");
            int numero_libro = int.Parse(Console.ReadLine());
            libros[numero_libro].estado = "disponible";
        }

        static void MostrarPrestados()
        {
            Console.WriteLine("Función mostrar prestados");
            foreach (var item in libros)
            {
                if (item.estado == "prestado") {
                    Console.WriteLine(item);
                }

            }

        }
    }
}
