namespace Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos= new Metodos();


            int opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("Mercado de venta de productos");
                Console.WriteLine("1 Si quieres insertar un producto");
                Console.WriteLine("2 si quieres ver los productos en le arreglo");
                Console.WriteLine("3 Si quieres buscar un producto por precio");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no valida");
                    continue;
                }

                if (opcion == 1)
                {
                    Console.WriteLine("Nombre del producto:");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Precio del producto:");
                    double precio;
                    if (!double.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.WriteLine("Precio");
                        continue;
                    }

                    metodos.InsertarProducto(nombre, precio);
                    Console.WriteLine("Producto insertado.");
                }
                else if (opcion == 2)
                {
                    metodos.MostrarProductos();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Precio a buscar");
                    double precioBusqueda;
                    if (!double.TryParse(Console.ReadLine(), out precioBusqueda))
                    {
                        Console.WriteLine("No valido");
                        continue;
                    }

                    metodos.BuscarPorPrecio(precioBusqueda);
                }
             
            }
        }
    }
}
