using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_CINE
{
    delegate void DProductosEscasos(int pRefrescos, int pPalomitas);
    class CComida
    {
        private int refrescos;
        private int palomitas;

        private DProductosEscasos delProductos;

        public CComida(int pRefrescos, int pPalomitas)
        {
            Refrescos = pRefrescos;
            Palomitas = pPalomitas;

        }

        public int Refrescos { get { return refrescos; } set { refrescos = value; } }
        public int Palomitas { get { return palomitas; } set { palomitas = value; } }

        public void AdicionarMetodoComida(DProductosEscasos pMetodo)
        {
            delProductos += pMetodo;
        }
        public void EliminarMetodoComida(DProductosEscasos pMetodo)
        {
            delProductos -= pMetodo;
        }
        public void Trabajar(int pConsumo)
        {
            refrescos -= pConsumo;
            palomitas -= pConsumo;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Quedan{0} refrescos y {1} palomitas.", refrescos, palomitas);

            if (refrescos<5 ||palomitas < 5)
            {
                delProductos(refrescos, palomitas);
            }
        }


    }
}
