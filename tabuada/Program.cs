using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Mallu, digite um numero para multiplicar: ");
            numero = Convert.ToInt32 (Console.ReadLine());

            for(int x = 1; x <= 10; x++)
            {
                int resultado = numero * x;
                    Console.WriteLine($"{numero} X {x} = {resultado}");
               
            }

        }
    }
}
