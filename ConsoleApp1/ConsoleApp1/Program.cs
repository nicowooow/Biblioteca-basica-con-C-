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

        static List<Libro> libros = new List<Libro>();
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
            Console.WriteLine("------------------------");
            Console.Write("- Titulo del libro : ");
            string titulo = Console.ReadLine();
            Console.Write("- Autor del libro : ");
            string autor = Console.ReadLine();
            Console.Write("- Año de publicación del libro : ");
            int anio = Convert.ToInt32(Console.ReadLine());
            libros.Add(new Libro(titulo, autor, anio));
            Console.WriteLine("------------------------");
        }

        static void ListarLibros()
        {
            Console.WriteLine("------------------------");
            int posicion = 0;

            if (libros.Count == 0)
            {
                Console.WriteLine("La bibliotea no cuenta con libros aun ...");
                Console.WriteLine("------------------------");
                return;
            }

            libros.ForEach(libro =>
            {
                posicion++;
                Console.WriteLine($"{posicion}.- {libro.titulo}  ({libro.estado})");
            });
            Console.WriteLine("------------------------");
        }

        static void BuscarLibro()
        {
            Console.WriteLine("------------------------");
            Console.Write("Buscar libro por indice ( 1 ) o por nombre ( 2 ) : ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el número del libro que dessea buscar : ");
                    int posicion = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (libros.Count == 0)
                    {
                        Console.WriteLine("La bibliotea no cuenta con libros aun ...");
                        return;
                    }

                    if (libros.Count < posicion)
                    {
                        Console.WriteLine("La bibliotea no cuenta con este libro aun ...");
                        return;

                    }
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Titulo : {libros[posicion].titulo} \nAutor : {libros[posicion].autor} \nAño: {libros[posicion].anio} \nEstado: {libros[posicion].estado}");

                    break;
                case 2:

                    Console.Write("Ingrese el titulo del libro que dessea buscar : ");
                    string titulo = Console.ReadLine();
                    int contador = 0;
                    libros.ForEach(libro =>
                    {
                        if (libro.titulo == titulo)
                        {
                            Console.WriteLine("------------------------");
                            Console.WriteLine($"Titulo : {libro.titulo} \nAutor : {libro.autor} \nAño: {libro.anio} \nEstado: {libro.estado}");
                            return;
                        }
                        contador++;
                        if (libros.Count == contador)
                        {
                            Console.WriteLine("------------------------");
                            Console.WriteLine("libro no encontrado...");
                            return;
                        }

                    });

                    break;
                case 0:
                default:
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Escriba bien la opcion a elegir...");
                    break;
            }

            Console.WriteLine("------------------------");

        }

        static void MarcarPrestado()
        {
            Console.WriteLine("Función marcar como prestado");
            Console.Write("Que libro quieres prestar: ");
            int numero_libro = int.Parse(Console.ReadLine()) - 1;
            libros[numero_libro].estado = "prestado";
            Console.WriteLine($"{numero_libro}.- {libros[numero_libro].titulo}  ({libros[numero_libro].estado})");
        }

        static void MarcarDevuelto()
        {
            Console.WriteLine("Función marcar como devuelto");
            Console.Write("Que libro quieres devolver: ");
            int numero_libro = int.Parse(Console.ReadLine());
            libros[numero_libro].estado = "disponible";
            Console.WriteLine($"{numero_libro}.- {libros[numero_libro].titulo}  ({libros[numero_libro].estado})");
        }

        /*
        static void MostrarPrestados()
        {
            Console.WriteLine("Función mostrar prestados");

            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].estado == "prestado")
                {
                    Console.WriteLine($"{i}.- {libros[i].titulo} ({libros[i].estado})");
                }
            }
        }
        */
        static void MostrarPrestados()
        {
            Console.WriteLine("Función mostrar prestados");
            int indice = 0;

            foreach (var item in libros)
            {
                if (item.estado == "prestado")
                {
                    Console.WriteLine($"{indice + 1}.- {item.titulo} ({item.estado})");
                }
                indice++;
            }
        }
    }
}
