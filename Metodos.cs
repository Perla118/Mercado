using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Metodos
    {

        private const int tamañoMercado = 5;
        private static Producto[] inventario = new Producto[tamañoMercado];

        private static int cantidadProductos = 0;

        // inserta en el arregloo
        public static void InsertarProducto(string nombre, double precio)
        {
            if (cantidadProductos < inventario.Length)
            {
                inventario[cantidadProductos] = new Producto { Nombre = nombre, Precio = precio };
                cantidadProductos++;
                Console.WriteLine("Producto");
            }
            else
            {
                Console.WriteLine("Arreglo lleno");
            }
        }

        // muestar los priductos del arreglo
        public static void MostrarProductos()
        {
            if (cantidadProductos == 0)
            {
                Console.WriteLine("No hay productos");
                return;
            }

            Console.WriteLine("Productos:");
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine($"Producto {i + 1} {inventario[i].Nombre} Precio {inventario[i].Precio}");
            }
        }

        //Ordenar inventaurio

        public static void OrdenarInventario()
        {

        }

        // Busqnda por precio 
        public static void BuscarPorPrecio(double precioaBuscar)
        {
            bool encontrado = false;

            Console.WriteLine($"Productos buscados {precioaBuscar}:");

            for (int i = 0; i < cantidadProductos; i++)
            {
               
                if (inventario[i].Precio == precioaBuscar)
                {
                    Console.WriteLine($"Producto {inventario[i].Nombre} Precio {inventario[i].Precio}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No hay");
            }
        }
    }

}
