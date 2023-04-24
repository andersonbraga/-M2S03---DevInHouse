namespace _M2S03___DevInHouse.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proprietario proprietario1 = new();
            Proprietario proprietario2 = new Proprietario();
            Proprietario proprietario3 = new Proprietario();

            proprietario1.Nome = "Joao";
            proprietario1.Cpf = "344.555.444.05";
            proprietario1.Telefone = "99-3443-3234";

            proprietario2.Nome = "Pedrao";
            proprietario2.Cpf = "224.545.432.33";
            proprietario2.Telefone = "44-332-2334";

            proprietario3.Nome = "Marlene";
            proprietario3.Cpf = "234.678.545.23";
            proprietario3.Telefone = "65-4223-3234";

        }
    }
}