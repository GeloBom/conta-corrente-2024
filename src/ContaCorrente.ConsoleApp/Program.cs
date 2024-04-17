namespace ContaCorrenteADP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente luiz = new Cliente("Luiz Gustavo H. Santos", "123.456.789-00");
            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1000, 4000, luiz);

            Cliente fulano = new Cliente("Fulano Siclano de beltrano", "000.000.000-12");
            ContaCorrente contaCorrente2 = new ContaCorrente(2, 500, 1500, fulano);

            //Cada conta terá operações de saques
            contaCorrente1.Sacar(200);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Parabens, voce realizou um saque! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");

            contaCorrente2.Sacar(600);
            Console.WriteLine($"Parabens, voce realizou um saque! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");

            //depósitos
            contaCorrente1.Deposito(600);
            Console.WriteLine($"Parabens, voce realizou um deposito! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");

            contaCorrente2.Deposito(700);
            Console.WriteLine($"Parabens, voce realizou um deposito! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");

            //transferência entre contas
            contaCorrente1.Transferencia(300, contaCorrente2);
            Console.WriteLine($"Parabens, voce realizou uma transferencia! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");
            Console.WriteLine($"Parabens, voce recebeu uma transferencia! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");

            //visualização de Saldo
            contaCorrente1.VerSaldo();
            contaCorrente2.VerSaldo();

            //visualização de extrato
            Console.WriteLine("\nExtrato conta 1:");

            for (int i = 0; i < contaCorrente1.Historico.Length; i++)
            {
                Movimentacao movimentacao = contaCorrente1.Historico[i];

                if (movimentacao != null)
                    Console.WriteLine(movimentacao.Tipo + " " + movimentacao.Valor);
            }
            Console.ReadLine();
        }
    }
}

//Uma conta corrente possui um número, um Saldo, um status que informa se ela é Especial ou não, um Limite e um histórico de movimentações.
//Uma movimentação possui um valor e uma informação se ela é uma movimentação de crédito ou débito. 

//Cada conta terá operações de saques, depósitos, visualização de Saldo, visualização de extrato e transferência entre contas. 

//Cada conta vai ter o nome, o NomeConta e Cpf do cliente dono da conta.  

//Uma conta corrente só pode fazer saques desde que o valor não exceda o Limite de saque que é o Limite + Saldo. Feito

//Não precisa implementar a interação com usuário.


