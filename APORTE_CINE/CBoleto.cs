using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_CINE
{
    class CBoleto
    {
        private string Nombre;
        private int Numero;
        private string Película;
        private tring Genero;
        private double duración;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Numero1 { get => Numero; set => Numero = value; }
        public string Película1 { get => Película; set => Película = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public double Duración { get => duración; set => duración = value; }


        public override string ToString()
        {
            return string.Format("Nombre; {0}, Número de asiento: {1}, Película:{2},Género:{3}, Duración {4} hrs.", Nombre, Numero, Película, Genero, duración);

                }
    }
}
