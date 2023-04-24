using _M2S03___DevInHouse.Ex5;

namespace _M2S03___DevInHouse.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proprietario proprietario1 = new();
            Proprietario proprietario2 = new Proprietario();
            Proprietario proprietario3 = new Proprietario();
            
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            proprietario1.Nome = "Joao";
            proprietario1.Cpf = "344.555.444.05";
            proprietario1.Telefone = "99-3443-3234";

            proprietario2.Nome = "Pedrao";
            proprietario2.Cpf = "224.545.432.33";
            proprietario2.Telefone = "44-332-2334";

            proprietario3.Nome = "Marlene";
            proprietario3.Cpf = "234.678.545.23";
            proprietario3.Telefone = "65-4223-3234";

            carro1.Modelo = " Hatch";
            carro1.Placa = "lze-3234";
            carro1.Marca = "GM";
            carro1.Cor = "Amarelo";
            carro1.Proprietario = proprietario1;

            carro2.Modelo = " Sedan";
            carro2.Placa = "ewf-2321";
            carro2.Marca = "GM";
            carro2.Cor = "Azul";
            carro2.Proprietario = proprietario2;

            carro3.Placa = "aqw-6801";
            carro3.Marca = "Ford";
            carro3.Cor = "Verde";
            carro3.Modelo = " SUV";
            carro3.Proprietario = proprietario3;

            List<Carro> carros = new List<Carro>();

            carros.Add(carro1);
            carros.Add(carro2);
            carros.Add(carro3);

            foreach (Carro carro in carros)
            {
                Console.WriteLine(carro.Proprietario.Nome);
            }

            






        }
    }
}