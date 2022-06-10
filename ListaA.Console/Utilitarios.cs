namespace ListaA
{
    public enum MenuOpt
    {
        Sair,
        Somar,
        Subtração,
        Multiplicação,
        Divisão

    }

    public class Operacoes
    {
        public double operacao(int tipo, double a, double b)
        {
            double result = 0;
            switch (tipo)
            {
                case (int)MenuOpt.Somar:
                    result = a + b;
                    break;
                case (int)MenuOpt.Subtração:
                    result = a - b;
                    break;
                case (int)MenuOpt.Multiplicação:
                    result = a * b;
                    break;
                case (int)MenuOpt.Divisão:
                    result = a / b;
                    break;

            }
            return result;
        }
    }
}