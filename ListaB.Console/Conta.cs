namespace ListaB
{
    public class Conta
    {
        private List<String> _extrato;
        public List<String> Extrato
        {
            get
            {
                return _extrato;
            }
            set
            {
                _extrato = value;
            }
        }
        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        public Conta()
        {
            Saldo = 0;
            Extrato = new List<String>();
        }

        public bool depositar(double valor)
        {
            if (valor > 0)
            {
                Extrato.Add("Depositou R$" + valor);
                Saldo = Saldo + valor;
                Extrato.Add("Saldo atualizado R$" + Saldo);
                Extrato.Add("-----------------------------");
                return true;
            }
            return false;
        }

        public bool sacar(double valor)
        {
            if (valor < Saldo)
            {
                Extrato.Add("Sacou R$" + valor);
                Saldo = Saldo - valor;
                Extrato.Add("Saldo atualizado R$" + Saldo);
                Extrato.Add("-----------------------------");
                return true;
            }
            return false;
        }

        public double saldo()
        {
            return Saldo;
        }

        public List<String> extrato()
        {
            return Extrato;
        }

    }
}