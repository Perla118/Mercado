namespace Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos= new Metodos();

            string si = "si";
            //string respuesta1;
            string respuesta1 = Console.ReadLine();

            Console.WriteLine("Quieres ingresar un producto si o no");
            respuesta1 = Console.ReadLine();
            

            if (respuesta1 == si)
            {
                
                Console.Write("Nombre del producto");
                string nombre = Console.ReadLine();

                Console.Write("Precio del producto");
                double precio = double.Parse(Console.ReadLine());
            }
            else
            {
                metodos.MostrarProductos();
            }



            Console.WriteLine("Quieres ingresar otro producto si o no");
            respuesta1 = Console.ReadLine();


            if (respuesta1 == si)
            {
               Console.Write("Nombre del producto");
                string nombre = Console.ReadLine();

                Console.Write("Precio del producto");
                double precio = double.Parse(Console.ReadLine());
            }
            else
            {
                metodos.MostrarProductos();
            }



            //Console.WriteLine("Quieres buscar un producto si o no");
            //respuesta1 = Console.ReadLine();


            //if (respuesta1 == si)
            //{

            //    Console.Write("Precio del producto");
            //    double precio = double.Parse(Console.ReadLine());

            //}
            //else
            //{
            //    metodos.MostrarProductos();
            //}




            Console.WriteLine("Quieres ver la lista de los productos si o no");
            respuesta1 = Console.ReadLine();

            if (respuesta1 == si)
            {
                metodos.MostrarProductos();
            }
            else
            {
                Console.WriteLine("No se eligió ver la lista de productos.");
            }

        }
    }
}
