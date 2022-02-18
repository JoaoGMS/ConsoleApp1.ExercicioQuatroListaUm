using System;

namespace ConsoleApp1.ExercicioQuatroListaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Celcius para Fahrenheit ");
            while (true)
            {
                
                double celsius, fahrenheit;

                Console.Write("Digite a temperatura em celsius: ");
                celsius = Convert.ToDouble(Console.ReadLine());

                fahrenheit = celsius * 1.8 + 32;

                Console.WriteLine("A conversão para fahrenheit resulta em {0}", Math.Round(fahrenheit, 1));

                Console.ReadKey();
            }while(true);
        }
    }
}
