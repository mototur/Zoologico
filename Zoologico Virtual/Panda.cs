using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Panda
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Panda(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionPanda()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas del Panda:");
            Console.WriteLine("El Panda: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionPanda()
        {
            Console.WriteLine("El Panda esta comiendo Bambu!!!");
        }
        public void sonidoPanda()
        {
            Console.WriteLine("El Panda comienza a bostezar gzzzzzz!!");
        }
        public void movimientosPanda()
        {
            Console.WriteLine("El Escala con sus garras un arbol gigante!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
