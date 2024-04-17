namespace ContaCorrenteADP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1, contaCorrente2;
            
            Dados(out contaCorrente1, out contaCorrente2);

            OperacoesSaque(contaCorrente1, contaCorrente2);

            OperacoesDeposito(contaCorrente1, contaCorrente2);

            OperacoesTransferencia(contaCorrente1, contaCorrente2);

            OperacoesSaldo(contaCorrente1, contaCorrente2);
           
            OperacoesExtrato(contaCorrente1, contaCorrente2);

            Console.ReadLine();
        }
       
        private static void Dados(out ContaCorrente contaCorrente1, out ContaCorrente contaCorrente2)
        {
            Cliente luiz = new Cliente("Luiz Gustavo H. Santos", "123.456.789-00");
            contaCorrente1 = new ContaCorrente(1, 1000, 4000, luiz);
            
            Cliente fulano = new Cliente("Fulano Siclano de beltrano", "000.000.000-12");
            contaCorrente2 = new ContaCorrente(2, 500, 1500, fulano);
        }
        
        private static void OperacoesSaque(ContaCorrente contaCorrente1, ContaCorrente contaCorrente2)
        {
            contaCorrente1.Sacar(200);
            Console.WriteLine($"Parabens, voce realizou um saque! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");

            contaCorrente2.Sacar(600);
            Console.WriteLine($"Parabens, voce realizou um saque! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");
        }
       
        private static void OperacoesDeposito(ContaCorrente contaCorrente1, ContaCorrente contaCorrente2)
        {
            contaCorrente1.Deposito(600);
            Console.WriteLine($"Parabens, voce realizou um deposito! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");

            contaCorrente2.Deposito(700);
            Console.WriteLine($"Parabens, voce realizou um deposito! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");
        }
        
        private static void OperacoesTransferencia(ContaCorrente contaCorrente1, ContaCorrente contaCorrente2)
        {
            contaCorrente1.Transferencia(300, contaCorrente2);
            Console.WriteLine($"Parabens, voce realizou uma transferencia! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");
            Console.WriteLine($"Parabens, voce recebeu uma transferencia! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");
        }

        private static void OperacoesSaldo(ContaCorrente contaCorrente1, ContaCorrente contaCorrente2)
        {
            contaCorrente1.VerSaldo();
            contaCorrente2.VerSaldo();
        }

        private static void OperacoesExtrato(ContaCorrente contaCorrente1, ContaCorrente contaCorrente2)
        {
            Console.WriteLine("\nExtrato conta 1:");

            for (int i = 0; i < contaCorrente1.Historico.Length; i++)
            {
                Movimentacao movimentacao = contaCorrente1.Historico[i];

                if (movimentacao != null)
                    Console.WriteLine($"{movimentacao.Tipo:F} R$ {movimentacao.Valor:F}");
            }

            Console.WriteLine("\nExtrato conta 2:");
            for (int i = 0; i < contaCorrente2.Historico.Length; i++)
            {
                Movimentacao movimentacao = contaCorrente2.Historico[i];

                if (movimentacao != null)
                    Console.WriteLine($"{movimentacao.Tipo:F} R$ {movimentacao.Valor:F}");
            }
        }
    }
}