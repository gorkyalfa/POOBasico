using System;

namespace SimulacionEconomica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");
            Random generador = new Random();

            int id = generador.Next();
            string nombre = "Darwin";

            Celular celular = new Celular
            {
                Id = generador.Next(),
                Marca = "Xiomi",
                Modelo = "Redmi note 8",
                Precio = 300
            };

            Persona estudiante = new Persona
            {
                Id = id,
                Nombre = nombre,
                MiCelular = celular
            };

            string personaLaQueSaludo = "Gorky";

            string saludo = estudiante.Saludar(personaLaQueSaludo);
            string productos = estudiante.Productos();

            Console.WriteLine(saludo);
            Console.WriteLine(productos);

            Console.ReadKey();
        }
    }
}
