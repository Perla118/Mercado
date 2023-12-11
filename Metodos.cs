using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Metodos
    {

        //Inserrtar un produycto
        private Producto[] productos = new Producto[10];
        private int cantidadProductos = 0;

        public void InsertarProducto()
        {
            if (cantidadProductos < productos.Length)
            {
                Console.Write("Nombre del producto");
                string nombre = Console.ReadLine();

                Console.Write("Precio del producto");
                double precio = double.Parse(Console.ReadLine());

                productos[cantidadProductos++] = new Producto { Nombre = nombre, Precio = precio };
            }
            else
            {
                Console.WriteLine("Arreglo lleno");
            }
        }

        //Mostrar productos
        public void MostrarProducto()
        {
            if (cantidadProductos>0)
            {

            }






        }

        //Ordnamiento de los productos
        //Busqueda de producto por precio
        public void BuscarProducto()
        {








        }


    }

}

