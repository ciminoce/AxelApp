using AxelApp.BL;
using System;
using AxelApp.Datos;

namespace AxelApp.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioDeTemperaturas repo = new RepositorioDeTemperaturas();
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    var temp = new Temperatura() {Valor = r.Next(10, 30)};
            //    repo.Agregar(temp);
            //    Console.WriteLine($"{temp.Valor}º celsius");
            //    Console.WriteLine($"{temp.GetEquivalenteFahrenheit()}º Fahrenheit");
            //    Console.WriteLine($"{temp.GetEquivalenteReaumur()}º Reaummur");
            //}

            Console.WriteLine($"Hay {repo.GetCantidad()} temperaturas en el repositorio");
            Console.ReadLine();
            Console.Clear();
            var lista = repo.GetLista();
            foreach (var temperatura in lista)
            {
                Console.WriteLine($"{temperatura.Valor}º celsius");
            }
            
            Console.ReadLine();
        }
    }
}
