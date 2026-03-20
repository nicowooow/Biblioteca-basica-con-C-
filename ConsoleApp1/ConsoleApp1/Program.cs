using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            Console.WriteLine("Función Añadir libro");
            Console.Write("- Titulo del libro : ");
            string titulo = Console.ReadLine();
            Console.Write("- Autor del libro : ");
            string autor = Console.ReadLine();
            Console.Write("- Año de publicación del libro : ");
            int anio = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Función añadir libro");

            libros.Add(new Libro(titulo, autor,anio));
        }

        static void ListarLibros()
        {
            int posicion = 0;

            libros.ForEach(libro=>
            {
                posicion++;
                Console.WriteLine($"{posicion}.- {libro.titulo}  ({libro.estado})");
            });
            Console.WriteLine("Función listar libros");
        }

        static void BuscarLibro()
        {
            Console.Write("Ingrese el número del libro que dessea buscar : ");
            int posicion = Convert.ToInt32(Console.ReadLine()) - 1;
            if (libros.Count == 0)
            {
                Console.WriteLine("La bibliotea no cuenta con libros aun ...");
                return;
            }
            Console.WriteLine($"Titulo : {libros[posicion].titulo} \nAutor : {libros[posicion].autor} \nAño: {libros[posicion].anio} \nEstado: {libros[posicion].estado}");
            Console.WriteLine("Función buscar libro");
        }

        static void MarcarPrestado()
        {
            Console.WriteLine("Función marcar como prestado");            
            Console.Write("Que libro quieres prestar: ");            
            int numero_libro = int.Parse(Console.ReadLine()) - 1;
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
                    Console.WriteLine($"{item}.- {item.titulo}  ({item.estado})");
                }

            }

        }
    }
}
