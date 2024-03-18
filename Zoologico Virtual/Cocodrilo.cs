using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Cocodrilo
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Cocodrilo(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionCocodrilo()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas del Cocodrilo:");
            Console.WriteLine("El Cocodrilo: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionCocodrilo()
        {
            Console.WriteLine("El Cocodrilo bebe agua!!!");
        }
        public void sonidoCocodrilo()
        {
            Console.WriteLine("El duerme!!");
        }
        public void movimientosCocodrilo()
        {
            Console.WriteLine("El Cocodrilo muerde una rama!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
