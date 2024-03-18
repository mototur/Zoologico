using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Serpiente
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Serpiente(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionSerpiente()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas de la serpiente:");
            Console.WriteLine("La serpiente: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionSerpiente()
        {
            Console.WriteLine("El Serpiente se come una rata!!!");
        }
        public void sonidoSerpiente()
        {
            Console.WriteLine("La serpiente hace ZZZZZZZ!!");
        }
        public void movimientosSerpiente()
        {
            Console.WriteLine("La serpiente muerde!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
