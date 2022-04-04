using System;

namespace TablaMultiplicarDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplicador
            //Multiplicando
            //Producto
            //2 x 3 = 6
            //2 x 4 = 8

            //2,3,4,
            int rangoMultiplicador = 10;
            int rangoMultiplicando = 10;
            int producto = 0;

            for (int multiplicador = 2; multiplicador < rangoMultiplicador; multiplicador++)
            {
                Console.WriteLine("ESTA ES LA TABLA DEL " + multiplicador);
                for (int multiplicando = 1; multiplicando < rangoMultiplicando; multiplicando++)
                {
                    producto = multiplicador * multiplicando;


                    Console.WriteLine(multiplicador + " x " + multiplicando + " = " + producto);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
