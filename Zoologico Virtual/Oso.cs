using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Oso
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Oso(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionOso()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas del Oso:");
            Console.WriteLine("El Oso: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionOso()
        {
            Console.WriteLine("El Oso esta comiendo Pescadooo!!!");
        }
        public void sonidoOso()
        {
            Console.WriteLine("El Oso Gruñe rawwwww!!");
        }
        public void movimientosOso()
        {
            Console.WriteLine("El Oso comienza a escalar un arbol!!!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
