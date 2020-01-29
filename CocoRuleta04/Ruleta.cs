using System;
using System.Collections.Generic;
using System.Text;


namespace CocoRuleta04
{
    class Ruleta
    {
        private int ganador;
        private List<Apuesta> ListaDeApuestas = new List<Apuesta>();

        public void GenerarGanador()
        {
            var random = new Random();
            this.ganador = random.Next(0, 36);
        }

        public int getGanador()
        {
            return this.ganador;
        }

        public void cargarApuesta(Apuesta apuesta)
        {
            this.ListaDeApuestas.Add(apuesta);
        }

        public void calcularGanadores()
        {
            int ganadores = 0;
            foreach (Apuesta a in ListaDeApuestas)
            {
                if (a.getSeleccion() == this.getGanador())
                {
                    ganadores++;
                } 
            }
            Console.WriteLine("El numero ganador es el: ¡¡¡" + this.getGanador() + "!!!");
            Console.WriteLine("La cantidad de ganadores es de: " + ganadores);
            Console.WriteLine("La cantidad de perdedores es de: " + (this.ListaDeApuestas.Count - ganadores) + " :c");
        }
    }
}
