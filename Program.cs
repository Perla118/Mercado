namespace Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos= new Metodos();


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
                metodos.MostrarProducto();
            }



            //Console.WriteLine("Quieres ingresar otro producto si o no");
            //respuesta1 = Console.ReadLine();


            //if (respuesta1 == si)
            //{
            //    Console.Write("Nombre del producto");
            //    string nombre = Console.ReadLine();

            //    Console.Write("Precio del producto");
            //    double precio = double.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    metodos.MostrarProducto();
            //}



            //Console.WriteLine("Quieres buscar un producto si o no");
            //respuesta1 = Console.ReadLine();


            //if (respuesta1 == si)
            //{

            //    Console.Write("Precio del producto");
            //    double precio = double.Parse(Console.ReadLine());

            //}
            //else
            //{
            //    metodos.MostrarProducto();
            //}




            //Console.WriteLine("Quieres ver la lista de los productos");
            //respuesta1 = Console.ReadLine();


            //if (respuesta1 == si)
            //{
            //    metodos.MostrarProducto();
            //}
            //else
            //{
            //    Console.WriteLine("Idk no hay productos");
            //}

        }
    }
}