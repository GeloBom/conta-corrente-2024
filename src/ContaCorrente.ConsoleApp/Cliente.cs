namespace ContaCorrenteADP
{
    public class Cliente
    {
        public string numeroConta, nomeConta, cpf;

        public Cliente(string nomeConta, string cpf)
        {
            this.nomeConta = nomeConta;
            this.cpf = cpf;
        }
    }
}