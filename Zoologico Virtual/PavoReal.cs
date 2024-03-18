using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class PavoReal
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public PavoReal(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionPavoReal()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del pavo real:");
            Console.WriteLine("El Pavo Real: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionPavoReal()
        {
            Console.WriteLine("El pavo real come maiz ");
        }
        public void sonidoPavoReal()
        {
            Console.WriteLine("El pavo real hace glu glu!!");
        }
        public void movimientosPavoReal()
        {
            Console.WriteLine("El pavo real extiende sus alas!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
