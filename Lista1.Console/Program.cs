using System;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero da questão");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    string nome, dataNascimento;
                    double salario;
                    int porcentagem;

                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Data Nascimento: ");
                    dataNascimento = Console.ReadLine();
                    Console.WriteLine("Salario: ");
                    salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Porcentagem: ");
                    porcentagem = int.Parse(Console.ReadLine());

                    Lista1.Console.Ex1 ex1 = new Lista1.Console.Ex1(nome, dataNascimento, salario, porcentagem);
                    Console.WriteLine(ex1.retorno());
                    break;
                case 2:
                    double[] notas = new double[6];
                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("Digite a " + (i + 1) + "ª nota");
                        double nota = double.Parse(Console.ReadLine());
                        while (nota < 0 || nota > 10)
                        {
                            Console.WriteLine("Valor deve ser de 0 a 10");
                            nota = double.Parse(Console.ReadLine());
                        }
                        notas[i] = nota;
                    }
                    Lista1.Console.Ex2 ex2 = new Lista1.Console.Ex2(notas);
                    Console.WriteLine(ex2.verificaNotas());
                    break;

                case 3:
                    break;
            }


        }
    }
}