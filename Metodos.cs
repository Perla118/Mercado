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
        private static Productos[] inventario = new Productos[tamañoMercado];

        private static int cantidadProductos = 0;

        // Para insertar un producto en el arreglo
        public static void InsertarProducto(string nombre, double precio)
        {
            if (cantidadProductos < inventario.Length)
            {
                inventario[cantidadProductos] = new Productos { Nombre = nombre, Precio = precio };
                cantidadProductos++;
                Console.WriteLine("Producto");
            }
            else
            {
                Console.WriteLine("Arreglo lleno");
            }
        }

        // productos del arreglo
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








        // Busqnda por precio 
        public static void BuscarPorPrecio(double precioaBuscar)
        {
            bool encontrado = false;

            Console.WriteLine($"Productos buscados {precioaBuscar}:");

            for (int i = 0; i < cantidadProductos; i++)
            {
                if (Math.Abs(inventario[i].Precio - precioaBuscar) < 0.0001)
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
