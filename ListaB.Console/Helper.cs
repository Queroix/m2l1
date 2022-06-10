namespace ListaB
{
    public class Helper
    {
        public enum MenuOpt
        {
            Sair, Depositar, Sacar, Saldo, Extrato
        }
        public static string Menu()
        {
            return "Bem vindo!\n"
            + "Selecione a opção desejada:\n"
            + "1 - Realizar Deposito\n"
            + "2 - Realizar Saque\n"
            + "3 - Consultar Saldo\n"
            + "4 - Consultar Extrato\n"
            + "0 - Sair\n";
        }
    }
}