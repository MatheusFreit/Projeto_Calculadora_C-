using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> 6bdb29b (atualizando o codigo)

namespace Projeto_com_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Vamos calulcar os numeros ");
            Console.WriteLine("Digite um numero: ");
            UInt32 num1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            UInt32 num2 = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Lista de Opção!");
=======
            // Exibe mensagem para solicitar que o usuário insira dois números
            Console.WriteLine("Vamos calcular dois números.");

            // Solicita que o usuário insira o primeiro número
            Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Solicita que o usuário insira o segundo número
            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Exibe uma lista de opções para o usuário escolher
            Console.WriteLine("Opções:");
>>>>>>> 6bdb29b (atualizando o codigo)
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
<<<<<<< HEAD
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
=======

            // Solicita que o usuário insira o número correspondente à opção desejada
            Console.WriteLine("Escolha uma opção:");
            UInt32 num3 = Convert.ToUInt32(Console.ReadLine());

            // Usa uma instrução switch para determinar qual operação matemática executar
            switch (num3)
            {
                case 1:
                    // Executa a adição e exibe o resultado no console
                    Console.WriteLine("Você somou os números " + num1 + " + " + num2 + " = " + (num1 + num2).ToString("N2"));
                    break;
                case 2:
                    // Executa a subtração e exibe o resultado no console
                    Console.WriteLine("Você subtraiu os números " + num1 + " - " + num2 + " = " + (num1 - num2).ToString("N2"));
                    break;
                case 3:
                    // Executa a multiplicação e exibe o resultado no console
                    Console.WriteLine("Você multiplicou os números " + num1 + " * " + num2 + " = " + (num1 * num2).ToString("N2"));
                    break;
                case 4:
                    // Executa a divisão e exibe o resultado no console
                    Console.WriteLine("Você dividiu os números " + num1 + " / " + num2 + " = " + (num1 / num2).ToString("N2"));
                    break;
                default:
                    // Exibe uma mensagem de erro se o usuário escolher uma opção inválida
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            // Aguarda que o usuário pressione uma tecla antes de sair
>>>>>>> 6bdb29b (atualizando o codigo)
            Console.ReadKey();
        }
    }
}
