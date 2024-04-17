namespace ContaCorrenteADP
{
    public class Movimentacao
    {
        public string Tipo;
        public decimal Valor;

        public Movimentacao(decimal valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }
    }
}
