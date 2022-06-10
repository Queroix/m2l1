namespace ListaB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Criar uma aplicação de console para simular de maneira simples operações bancárias
            Entrada: Receber Informação de Operação
            Saída: Baseado na operação mostrar o resultado
            Ter uma opção no menu para parar a aplicação senão, enquanto isso, após o resultado,
            mostra para selecionar a outra operação.

            Crie Menu (Adicionar uma cor para o texto do menu, valor inicial de saldo é 0)
            - operações: consulta saldo, depósito, saque, histórico, sair

            Crie método de consulta de saldo e implemente a lógica necessária e o resultado esperado

            Crie método para depósito e implemente a lógica necessária e o resultado esperado
            **Validação**: não pode enviar números negativos (mostrar em cor vermelha a mensagem da validação)
            
            Crie método para saque -  adicionar e atualizar saldo
            **Validação:** quando não tiver saldo suficiente (mostrar em cor vermelha a mensagem da validação)

            Crie método de **histórico de operação** - para armazenar em uma lista as operações e valores da transação 
            (como se fosse um extrato bancário)
            */

            Conta suaConta = new Conta();
            Console.WriteLine(Helper.Menu());
            int opt = int.Parse(Console.ReadLine());

            while (opt > 0 && opt <= 4)
            {
                Console.Clear();
                switch (opt)
                {
                    case (int)Helper.MenuOpt.Depositar:
                        Console.WriteLine("Digite o valor que deseja depositar:");
                        if (suaConta.depositar(double.Parse(Console.ReadLine())))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Sucesso");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Falha Deposito.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case (int) Helper.MenuOpt.Sacar:
                        Console.WriteLine("Digite o valor que deseja sacar:");
                        if (suaConta.sacar(double.Parse(Console.ReadLine())))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Sucesso");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Falha Saque.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case (int)Helper.MenuOpt.Saldo:
                        System.Console.WriteLine("Seu saldo é de R$" + suaConta.saldo());
                        break;
                    case (int)Helper.MenuOpt.Extrato:
                        List<String> extrato = suaConta.extrato();
                        if (extrato.Count() > 0)
                        {
                            foreach (var item in extrato)
                            { Console.WriteLine(item); }
                        }
                        else
                        {
                            System.Console.WriteLine("Sem registros.");
                        }
                        break;
                }
                Console.WriteLine("Tecle [ENTER] para continuar");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine(Helper.Menu());
                opt = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fim...");
            Console.ReadLine();

        }
    }
}