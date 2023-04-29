using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_com_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calulcar os numeros ");
            Console.WriteLine("Digite um numero: ");
            UInt32 num1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            UInt32 num2 = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Lista de Opção!");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            UInt32 num3 = Convert.ToUInt32(Console.ReadLine());

            switch (num3) {
                case 1:
                    Console.WriteLine("Você somou os numeros " + num1 + " + " + num2 + " = " + (num1 + num2).ToString("N2"));
                    break;
                case 2:
                    Console.WriteLine("Você Subtraiu os numeros " + num1 + " - " + num2 + " = " + ((double)num1 - num2).ToString("N2"));
                    break;
                case 3:
                    Console.WriteLine("Você Multiplicou  os numeros " + num1 + " * " + num2 + " = " + (num1 * num2).ToString("N2"));
                    break;
                case 4: 
                    Console.WriteLine("Você dividiu os numeros " + num1 + " / " + num2 + " = " + ((double)num1 / num2).ToString("N2"));
                    break;
            }
            Console.ReadKey();
        }
    }
}
