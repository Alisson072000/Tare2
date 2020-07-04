using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title="PANADERIA ALISSON";
            var random = new Random();
            Cliente cliente = new Cliente
            {
                Id = new Random().Next(),
                Nombre = "Alisson",
                Apellido = "chavez",
                Direccion = "Guamani",
                Preferencia = new Producto
                {
                    Id = random.Next(),
                    Nombre = "Pan de Chocolate",
                    Ingredientes = "Harina,Huevos,Chocolate",
                    Calorias = 5,
                }

            };
            Empleado empleado = new Empleado
            {
                Id = new Random().Next(),
                Nombre = "Olga",
                Apellido = "Tenorio",
                Direccion = "Guamani",
                Funcion = new Cargo
                {
                    Id = random.Next(),
                    Nombre = "Vendedor",
                    Descripcion = "Ayuda a los clientes con su pedido"
                }

            };
            Console.WriteLine(empleado.Saludar());
            Console.WriteLine(empleado.Informacion());
            Console.WriteLine(empleado.Atender());
            Console.WriteLine(cliente.Saludar());
            Console.WriteLine(cliente.productoPreferencia());
            Console.ReadKey();
        }
    }
}

