namespace Lista1.Console
{
    public class Ex1
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        private string _dataNascimento;
        public string DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
            set
            {
                _dataNascimento = value;
            }
        }
        private double _salario;
        public double Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
            }
        }
        private double _salarioNovo;
        public double SalarioNovo
        {
            get
            {
                return _salarioNovo;
            }
            set
            {
                _salarioNovo = value;
            }
        }
        private int _porcentagem;
        public int Porcentagem
        {
            get
            {
                return _porcentagem;
            }
            set
            {
                _porcentagem = value;
            }
        }

        public Ex1(string nome, string dataNascimento, double salario, int porcentagem)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Salario = salario;
            Porcentagem = porcentagem;
            SalarioNovo = salario + (salario * porcentagem / 100);
        }

        public string retorno()
        {
            return "O salario de " + Nome + " eh de R$" + Salario + " e ganhou " + Porcentagem + "% de reajuste. Total do novo salario é de R$" + SalarioNovo;
        }

    }
}