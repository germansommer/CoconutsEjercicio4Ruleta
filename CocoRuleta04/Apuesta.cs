using System;
using System.Collections.Generic;
using System.Text;

namespace CocoRuleta04
{
    //Declaracion de clase y metodos accesores.
    class Apuesta
    {
        private int seleccion;

        public void setSeleccion(int seleccion)
        {
            this.seleccion = seleccion;
        }

        public int getSeleccion()
        {
            return this.seleccion;
        }
    }
}
