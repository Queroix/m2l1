using System;

namespace ListaA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Operacoes op = new Operacoes();
            int opt;
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Efetuar Operação Soma");
            Console.WriteLine("2 - Efetuar Operação Subtração");
            Console.WriteLine("3 - Efetuar Operação Multiplicação");
            Console.WriteLine("4 - Efetuar Operação Divisão");
            Console.WriteLine("0 - Encerrar");

            opt = int.Parse(Console.ReadLine());
            while (opt < 0 || opt > 4)
            {
                Console.WriteLine("Opção Invalida");
                opt = int.Parse(Console.ReadLine());
            }
            while (opt != 0)
            {
                Console.WriteLine("Digite o primeiro valor:");
                double A = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                double B = double.Parse(Console.ReadLine());

                Console.WriteLine("Resultado da operação: " + op.operacao(opt, A, B));

                Console.WriteLine("Fim operação...");

                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("1 - Efetuar Operação Soma");
                Console.WriteLine("2 - Efetuar Operação Subtração");
                Console.WriteLine("3 - Efetuar Operação Multiplicação");
                Console.WriteLine("4 - Efetuar Operação Divisão");
                Console.WriteLine("0 - Encerrar");

                opt = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fim operação.");
        }
    }
}