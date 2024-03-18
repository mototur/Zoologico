using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Mono
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Mono(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionMono()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas del Mono:");
            Console.WriteLine("El Mono: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionMono()
        {
            Console.WriteLine("El Mono Esta comiendo platanos!!!!!");
        }
        public void sonidoMono()
        {
            Console.WriteLine("El Tigre comienza a cantar uh uh ah ah!!!!");
        }
        public void movimientosMono()
        {
            Console.WriteLine("El Mono comienza a saltar en las lianas!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
