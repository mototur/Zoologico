using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Leon
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Leon(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }
        public void informacionLeon()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas del Leon:");
            Console.WriteLine("El Leon: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionLeon()
        {
            Console.WriteLine("El leon esta chupando un hueso!!!");
        }
        public void sonidoLeon()
        {
            Console.WriteLine("El leon le hace grrrawww!!");
        }
        public void movimientosLeon()
        {
            Console.WriteLine("El Leon salta!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }



    }
}
