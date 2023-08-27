using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recebendo dados do user
            Console.WriteLine("QUAL OPERAÇÃO VOCÊ DESEJA FAZER?");
            Console.WriteLine("1- ADIÇÃO");
            Console.WriteLine("2- SUBTRAÇÃO");
            Console.WriteLine("3- MULTIPLICAÇÃO");
            Console.WriteLine("4- DIVISÃO \n");

            //Declarando variável para guardar as escolha do user
            int operacao = int.Parse(Console.ReadLine());

            //Recebendo os números do usuário
            Console.WriteLine("Digite o primeiro número: ");
            //Declarando e convertendo a variável ao mesmo tempo
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            //Declarando variável que mostrará o resultado
            int resultado = 0;


            //Condicional de comparação 
            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }

                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }

                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("NÚMERO INVÁLIDO, DIGITE OUTRO NÚMERO");
                    break;
            }

            Console.WriteLine("VOCÊ DIGITOU OS SEGUINTES NÚMEROS: {0} E {1} \nO RESULTADO DA OPERAÇÃO É: {2}", num1, num2, resultado);

            Console.ReadLine();
        }



        //Métodos (precisam ser fora do método principal)
        // por mais que as variáveis sejam iguais ao método prinicpal, não são as mesmas e sua alteração não quebra o código
        public static int Adicao(int varRecebenum1, int varRecebenum2)
        {
            int Resultado = varRecebenum1 + varRecebenum2;
            return Resultado;
        }
        public static int Subtracao(int varRecebenum1, int varRecebenum2)
        {
            int Resultado = varRecebenum1 - varRecebenum2;
            return Resultado;
        }

        public static int Multiplicacao(int varRecebenum1, int varRecebenum2)
        {
            int Resultado = varRecebenum1 * varRecebenum2;
            return Resultado;
        }

        public static int Divisao(int varRecebenum1, int varRecebenum2)
        {
            int Resultado = varRecebenum1 / varRecebenum2;
            return Resultado;
        }
    }
}
