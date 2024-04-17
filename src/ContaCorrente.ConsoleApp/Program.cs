namespace ContaCorrenteADP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente luiz = new("Luiz Gustavo H. Santos", "123.456.789-00");
            ContaCorrente contaCorrente1 = new(1, 1000, 4000, luiz);

            Cliente fulano = new("Fulano Siclano de beltrano", "000.000.000-12");
            ContaCorrente contaCorrente2 = new(2, 500, 1500, fulano);

            contaCorrente1.Sacar(200);
            Console.WriteLine($"Parabens, voce realizou um saque! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");

            contaCorrente2.Sacar(600);
            Console.WriteLine($"Parabens, voce realizou um saque! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");

            contaCorrente1.Deposito(600);
            Console.WriteLine($"Parabens, voce realizou um deposito! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");

            contaCorrente2.Deposito(700);
            Console.WriteLine($"Parabens, voce realizou um deposito! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");

            contaCorrente1.Transferencia(300, contaCorrente2);
            Console.WriteLine($"Parabens, voce realizou uma transferencia! Seu saldo atual é de R$ {contaCorrente1.VerSaldo():F}");
            Console.WriteLine($"Parabens, voce recebeu uma transferencia! Seu saldo atual é de R$ {contaCorrente2.VerSaldo():F}");

            contaCorrente1.VerSaldo();
            contaCorrente2.VerSaldo();

            Console.WriteLine("\nExtrato conta 1:");

            contaCorrente1.MostrarExtrato();

            Console.WriteLine("\nExtrato conta 2:");

            contaCorrente2.MostrarExtrato();
        }
    }
}