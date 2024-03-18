using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Tortuga
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Tortuga(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionTortuga()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas de la tortuga:");
            Console.WriteLine("La tortuga: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionTortuga()
        {
            Console.WriteLine("La tortuga come tortilla!!");
        }
        public void sonidoTortuga()
        {
            Console.WriteLine("No quiere hacer ningun sonido!!");
        }
        public void movimientosTortuga()
        {
            Console.WriteLine("El Tortuga camina muy lento!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
