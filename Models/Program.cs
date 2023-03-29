using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Program
    {
        public void Principal()
        {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            int operacao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                
                    resultado = Adicao(num1, num2);
                    break;
                
                case 2:
                
                    resultado = Subtracao(num1, num2);
                    break;
                case 3:
                
                    resultado = Multiplicacao(num1, num2);
                    break;
                case 4:
                
                    resultado = Divisao(num1, num2);
                    break;

                default:
                    throw new ExecutionEngineException("Selecionar apenas números de 1 a 4");

            }

            Console.WriteLine("O resultado da operação dos números {0} e {1} é: {2}", num1, num2, resultado);
            Console.ReadLine();

        }
          public int Adicao (int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
          public int Subtracao (int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
          public int Multiplicacao (int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
          public int Divisao (int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}