using System;

namespace Fatorial_de_un_Numero
{
    class Program
    {
        static int Factorial(int num)
        {
            int inicial = 1;
            int final = 2;

            int i = 0;

            do {

                inicial = inicial * final;
                final = final + 1;

                i++;

            } while (i < num-1);

            return inicial;
        }
        static void Main(string[] args)
        {
            String dato = " ";
            int numero;
            int resultado;

            Console.WriteLine("Factorial de un Numero\n");

            Console.Write("Digite un numero: ");
            dato = Console.ReadLine();
            numero = Convert.ToInt32(dato);

            resultado = Factorial(numero);

            Console.Write("El resultado de {0} es: {1}", numero, resultado);

        }
    }
}
