using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_CINE
{
    class CProveedor
    {
        public static void Rebastecer(int pRefrescos, int pPalomitas)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Vamos a mandar sus viveres ");
            Console.WriteLine("-->Serán{0} refrescos y {1} palomitas", pRefrescos, pPalomitas);

        }
    }
}
