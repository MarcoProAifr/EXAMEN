using System;
using System.Collections.Generic;

namespace APORTE_CINE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos la sala
            CSala sala1 = new CSala(10);
            Random rnd = new Random();

            //Creamos la comida
            CComida comida1 = new CComida(15, 15);

            //Variables para el multicasting, necesitamos la instancia para poder adicionar

            DAsientosDisponibles asientos1 = new DAsientosDisponibles(InformeAsientos);
            DProductosEscasos productos1 = new DProductosEscasos(InformeProductos);
            DProductosEscasos productos2 = new DProductosEscasos(CProveedor.Rebastecer);

            sala1.AdicionarMetodoAsientos(asientos1);
            comida1.AdicionarMetodoComida(productos1);
            comida1.AdicionarMetodoComida(productos2);

            List<CBoleto> boleto = new List<CBoleto>();
            boleto.Add(new CBoleto { Nombre1 = "Juan", Numero1 = 2, Película1 = "John Wick 3", Genero1 = "Acción", Duración = 2.1 });
            boleto.Add(new CBoleto { Nombre1 = "Adrian", Numero1 = 15, Película1 = "Aladdin", Genero1 = "Aventura", Duración = 2 });
            boleto.Add(new CBoleto { Nombre1 = "Annel", Numero1 = 20, Película1 = "Avengers", Genero1 = "Acción", Duración = 2.2 });
            boleto.Add(new CBoleto { Nombre1 = "Pedro", Numero1 = 18, Película1 = "Pikachu", Genero1 = "Acción", Duración = 2 });
            boleto.Add(new CBoleto { Nombre1 = "Annel", Numero1 = 20, Película1 = "Avengers", Genero1 = "Acción", Duración = 2.2 });
            boleto.Add(new CBoleto { Nombre1 = "Pedro", Numero1 = 18, Película1 = "Pikachu", Genero1 = "Acción", Duración = 2 });
            boleto.Add(new CBoleto { Nombre1 = "Annel", Numero1 = 20, Película1 = "Avengers", Genero1 = "Acción", Duración = 2.2 });
            boleto.Add(new CBoleto { Nombre1 = "Pedro", Numero1 = 18, Película1 = "Pikachu", Genero1 = "Acción", Duración = 2 });
            int op = 0;
            string name = "";
            int number = 0;
            string movie = "";
            string gender = "";
            double time = 0.0;

            while (op != 4)
            {
                Console.WriteLine("\n--------------------MENÚ--------------------");
                Console.WriteLine("\n-------------SUPERCINES 8--------------------");
                Console.WriteLine("\n-----Dame una opcion: \n");
                Console.WriteLine("1.- Vender boletos\n2. Mostrar boletos vendidos\n3. Comprar en comida\n4. Salir");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("dame el nombre del titular del boleto:");
                        name = Console.ReadLine();

                        Console.WriteLine("dame el nombre de asiento que deseas:");
                        number = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Dime la pelicula por entrar:");
                        movie = Console.ReadLine();

                        Console.WriteLine("Dame el género de la película:");
                        gender = Console.ReadLine();

                        Console.WriteLine("Dame la duración de la película:");
                        time = Convert.ToDouble(Console.ReadLine());

                        boleto.Add(new CBoleto { Nombre1 = name, Numero1 = number, Película1 = movie, Genero1 = gender, Duración = time });
                        sala1.Trabajar(boleto.Count);
                        Console.WriteLine("============================");

                        break;

                    case 2:

                        foreach (CBoleto boletos in boleto)
                        {
                            Console.WriteLine(boletos);
                        }

                        break;

                    case 3:
                        while (comida1.Palomitas>0 || comida1.Refrescos > 0)
                        {
                            comida1.Trabajar(rnd.Next(1, 5));
                        }
                        Console.WriteLine("============================");
                        break;

                    case 4:
                        Console.WriteLine("Hasta luego, tenga un buen día :D");
                        Console.WriteLine("==================");
                        break;

                    default:

                        Console.WriteLine("Opcion invalida ");
                        break;


                }
            }
        }

        public static void InformeAsientos(int pAsientos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> pocos asientos disponibles para la sala:");
            Console.WriteLine("--> Quedan {0} asientos:",pAsientos);
        }
        public static void InformeProductos (int pRefrescos, int pPalomitas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Se están acabando los refrescos");
            Console.WriteLine("--> Quedan {0} refrescos y {1} palomitas.",pRefrescos, pPalomitas);
        }
    }
}
