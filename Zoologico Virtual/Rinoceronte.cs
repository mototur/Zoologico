using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Rinoceronte
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Rinoceronte(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionRinoceronte()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas del Rinoceronte:");
            Console.WriteLine("El Rinoceronte: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionRinoceronte()
        {
            Console.WriteLine("El Rinoceronte esta bebiendo agua!!!");
        }
        public void sonidoRinoceronte()
        {
            Console.WriteLine("El Rinoceronte esta gruyendo!!");
        }
        public void movimientosRinoceronte()
        {
            Console.WriteLine("El Rinoceronte comienza una estocada!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
