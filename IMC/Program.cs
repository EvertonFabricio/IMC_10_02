using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua altura");
			var altura = float.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora precisamos saber seu sexo. Digite M se for mulher ou H se for homem: ");
			var sexo = char.Parse(Console.ReadLine());

            if (sexo == 'M' || sexo == 'm')
                Console.WriteLine($"\nComo você é uma mulher, seu peso ideal é {62.1 * altura - 44.7}");
            else if (sexo == 'H' || sexo == 'h')
                Console.WriteLine($"\nComo você é uma homem, seu peso ideal é {72.7 * altura - 58}");

            else
                Console.WriteLine("A informação de sexo está incorreta, execute o programa novamente.");

        }
    }
}
