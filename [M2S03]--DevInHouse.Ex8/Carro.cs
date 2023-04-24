using _M2S03___DevInHouse.Ex3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S03___DevInHouse.Ex5
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public Proprietario Proprietario { get; set; }

        public void CadastrarCarro(List<Carro> carros, List<Proprietario> proprietarios)
        {
            Proprietario proprietario = new Proprietario();
            Carro carro = new Carro();

            Console.WriteLine("Insira o nome do proprietario: ");
            proprietario.Nome = Console.ReadLine();
            Console.WriteLine("Insira o cpf do proprietario: ");
            proprietario.Cpf = Console.ReadLine();
            Console.WriteLine("Insira o telefone do proprietario: ");
            proprietario.Telefone = Console.ReadLine();
            

            Console.WriteLine("Insira o modelo do carro: ");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine("Insira a cor do carro: ");
            carro.Cor = Console.ReadLine();
            Console.WriteLine("Insira a placa do carro: ");
            carro.Placa = Console.ReadLine();
            Console.WriteLine("Insira a marca do carro: ");
            carro.Marca = Console.ReadLine();

            carros.Add(carro);
            proprietarios.Add(proprietario);




        }
    }
}
