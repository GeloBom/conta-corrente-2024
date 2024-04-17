
namespace ContaCorrenteADP
{
    public class ContaCorrente
    {
        public int numero;
        public decimal saldo, limite;

        public Cliente titular;

        public Movimentacao[] Historico;
        private int qtdMovimentacoes;

        public ContaCorrente(int numero, decimal saldo, decimal limite, Cliente titular)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
            this.titular = titular;

            Historico = new Movimentacao[100];
        }

        public bool Sacar(decimal valor)
        {

            if (valor > limite + saldo)
            {
                Console.WriteLine("Saldo Insufuciente, tente novamente...");
                return false;
            }
            else
            {
                saldo -= valor;

                Movimentacao movimentacao = new(valor, "Saque");

                RegistrarMovimentacao(movimentacao);
            }
            return true;
        }

        public void Deposito(decimal valor)
        {
            saldo += valor;

            Movimentacao movimentacao = new(valor, "Deposito");

            RegistrarMovimentacao(movimentacao);
        }

        public bool Transferencia(decimal valor, ContaCorrente destinatario)
        {
            bool conseguiuSacar = Sacar(valor);

            if (conseguiuSacar == false)
                return false;

            destinatario.Deposito(valor);

            return true;
        }
        public decimal VerSaldo()
        {
            return saldo;
        }

        public void RegistrarMovimentacao(Movimentacao movimentacao)
        {
            Historico[qtdMovimentacoes] = movimentacao;
            qtdMovimentacoes++;
        }

        internal void MostrarExtrato()
        {
            for (int i = 0; i < Historico.Length; i++)
            {
                Movimentacao movimentacao = Historico[i];

                if (movimentacao != null)
                    Console.WriteLine($"{movimentacao.Tipo:F} R$ {movimentacao.Valor:F}");
            }
        }
    }
}