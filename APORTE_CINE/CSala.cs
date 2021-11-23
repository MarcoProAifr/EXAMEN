using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_CINE
{
    delegate void DAsientosDisponibles(int pAsientos);
    class CSala: CBoleto
    {
        private int asientosDisponibles;
        private DAsientosDisponibles delAsientos;
        
        public CSala(int pAsientos)
        {
            asientosDisponibles = pAsientos;
        }
        public void AdicionarMetodoAsientos(DAsientosDisponibles pMetodo)
        {
            delAsientos += pMetodo;

        }
        public void EliminarMetodoAsientos(DAsientosDisponibles pMetodo)
        {
            delAsientos -= pMetodo;
        }
        public int AsientosD { get { return asientosDisponibles; } set { asientosDisponibles = value; } }

        public void Trabajar(int pConsumo)
        {
            asientosDisponibles = 10 - pConsumo;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Asientos Disponibles {0}", asientosDisponibles);

            if (asientosDisponibles < 5)
            {
                delAsientos(asientosDisponibles);
            }
        }
    }
}
