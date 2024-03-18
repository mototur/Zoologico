using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool abandonar = false;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("BIENVENIDOS A MI ZOOLOGICO VIRTUAL");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Ingrese un numero:  ");
                Console.WriteLine("0. Abandonar");
                Console.WriteLine("1. Visitar Leon");
                Console.WriteLine("2. Visitar Elefante");
                Console.WriteLine("3. Visitar Jirafa");
                Console.WriteLine("4. Visitar Tigre");
                Console.WriteLine("5. Visitar Mono");
                Console.WriteLine("6. Visitar oso");
                Console.WriteLine("7. Visitar Cocodrilo");
                Console.WriteLine("8. Visitar Serpiente");
                Console.WriteLine("9. Visitar Pinguino");
                Console.WriteLine("10. Visitar Lobo");
                Console.WriteLine("11. Visitar Cebra");
                Console.WriteLine("12. Visitar Rinoceronte");
                Console.WriteLine("13. Visitar Panda");
                Console.WriteLine("14. Visitar Pavoreal");
                Console.WriteLine("15. Visitar Tortuga");
                int ingresoUsuario = int.Parse(Console.ReadLine());

                switch (ingresoUsuario)
                {
                    case 0: abandonar = true; break;
                    case 1:
                        Leon leon = new Leon("Simba", 8.9, 2.8, "Masculino");
                        leon.informacionLeon();
                        leon.alimentacionLeon();
                        leon.sonidoLeon();
                        leon.movimientosLeon();
                        break;
                    case 2:
                        Elefante elefante = new Elefante("Dumbo", 430, 2.10, "Masculino");
                        elefante.informacionElefante();
                        elefante.alimentacionElefante();
                        elefante.sonidoElefante();
                        elefante.movimientosElefante();
                        break;
                    case 3:
                        Jirafa jirafa = new Jirafa("Fer", 202, 3.5, "Femenino");
                        jirafa.informacionJirafa();
                        jirafa.alimentacionJirafa();
                        jirafa.sonidoJirafa();
                        jirafa.movimientosJirafa();
                        break;
                    case 4:
                        Tigre tigre = new Tigre("Gaspar", 350, 1.20, "Masculino");
                        tigre.informacionTigre();
                        tigre.alimentacionTigre();
                        tigre.sonidoTigre();
                        tigre.movimientosTigre();
                        break;
                    case 5:
                        Mono mono = new Mono("Patrick", 0.65, 0.53, "Masculino");
                        mono.informacionMono();
                        mono.alimentacionMono();
                        mono.sonidoMono();
                        mono.movimientosMono();
                        break;
                    case 6:
                        Oso oso = new Oso("Alberto", 410, 1.68, "Masculino");
                        oso.informacionOso();
                        oso.alimentacionOso();
                        oso.sonidoOso();
                        oso.movimientosOso();
                        break;
                    case 7:
                        Cocodrilo cocodrilo = new Cocodrilo("Gru", 253, 1.38, "Masculino");
                        cocodrilo.informacionCocodrilo();
                        cocodrilo.alimentacionCocodrilo();
                        cocodrilo.sonidoCocodrilo();
                        cocodrilo.movimientosCocodrilo();
                        break;
                    case 8:
                        Serpiente serpiente = new Serpiente("Astrid", 40, 0.18, "Femenino");
                        serpiente.informacionSerpiente();
                        serpiente.alimentacionSerpiente();
                        serpiente.sonidoSerpiente();
                        serpiente.movimientosSerpiente();
                        break;
                    case 9:
                        Pinguino pinguino = new Pinguino("Enrique", 1.80, 200, "Masculino");
                        pinguino.informacionPinguino();
                        pinguino.alimentacionPinguino();
                        pinguino.sonidopinguino();
                        pinguino.movimientospinguino();
                        break;
                    case 10:
                        Lobo lobo = new Lobo("Yeik", 120, 0.45, "Masculino");
                        lobo.informacionLobo();
                        lobo.alimentacionLobo();
                        lobo.sonidoLobo();
                        lobo.movimientosLobo();
                        break;
                    case 11:
                        Cebra cebra = new Cebra("Manchas", 200, 0.65, "Femenino");
                        cebra.informacionCebra();
                        cebra.alimentacionCebra();
                        cebra.sonidoCebra();
                        cebra.movimientosCebra();
                        break;
                    case 12:
                        Rinoceronte rinoceronte = new Rinoceronte("Pawi", 650, 1.80, "Maculino");
                        rinoceronte.informacionRinoceronte();
                        rinoceronte.alimentacionRinoceronte();
                        rinoceronte.sonidoRinoceronte();
                        rinoceronte.movimientosRinoceronte();
                        break;
                    case 13:
                        Panda panda = new Panda("Chin", 112, 1.40, "Masculino");
                        panda.informacionPanda();
                        panda.alimentacionPanda();
                        panda.sonidoPanda();
                        panda.movimientosPanda();
                        break;
                    case 14:
                        PavoReal pavoreal = new PavoReal("Tovi", 50, 0.20, "Masculino");
                        pavoreal.informacionPavoReal();
                        pavoreal.alimentacionPavoReal();
                        pavoreal.sonidoPavoReal();
                        pavoreal.movimientosPavoReal();
                        break;
                    case 15:
                        Tortuga tortuga = new Tortuga("Fran", 6, 0.8, "Masculino");
                        tortuga.informacionTortuga();
                        tortuga.alimentacionTortuga();
                        tortuga.sonidoTortuga();
                        tortuga.movimientosTortuga();
                        break;
                    default: break;
                }
                Console.Clear();
            } while (!abandonar);




            Console.ReadLine();




        

        }
    }
}
    

