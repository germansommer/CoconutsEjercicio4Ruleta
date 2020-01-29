using System;

namespace CocoRuleta04
{
    class Program
    {                
        static void Main(string[] args)
        {
            //Creacion de Variables.
            int entrada = 0;
            Ruleta ruleta = new Ruleta();
            //Carga y control de Apuestas.
            do
            {
                Console.WriteLine("Ingrese una nueva apuesta: ");
                try
                {
                    entrada = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
                if ((entrada >= 0) && (entrada < 37))
                {
                    var apuesta = new Apuesta();
                    apuesta.setSeleccion(entrada);
                    ruleta.cargarApuesta(apuesta);
                }
            } while ((entrada >= 0) && (entrada < 37));
            //Generacion de numero random y cuenta de ganadores.
            ruleta.GenerarGanador();
            ruleta.calcularGanadores();
        }
    }
}
