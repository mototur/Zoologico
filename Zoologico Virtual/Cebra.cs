using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Cebra
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Cebra(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionCebra()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y caracteristicas de la cebra:");
            Console.WriteLine("La cebra: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionCebra()
        {
            Console.WriteLine("La Cebra esta comiendo hiervas!!!");
        }
        public void sonidoCebra()
        {
            Console.WriteLine("La Cebra esta relinchando !!");
        }
        public void movimientosCebra()
        {
            Console.WriteLine("La cebra se esta echando!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
