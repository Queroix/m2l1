namespace Lista1.Console
{
    public class Ex2
    {
        private double[] _notas = new double[6];
        public double[] Notas
        {
            get
            {
                return _notas;
            }
            set
            {
                _notas = value;
            }
        }
        public int _maior;
        public int _menor;
        public int _zero;
        public Ex2(double[] notas)
        {
            Notas = notas;
            _maior = 0;
            _menor = 0;
            _zero = 0;
        }

        public string verificaNotas()
        {
            foreach (int i in Notas)
            {

                if (i >= 7)
                {
                    _maior++;
                }
                else if (i > 0)
                {
                    _menor++;
                }
                else
                {
                    _zero++;
                }
            }
            return "Maior ou igual " + _maior + "\nMenor " + _menor+"\nZero " + _zero + "\nMedia " + Notas.Average();
        }
    }
}