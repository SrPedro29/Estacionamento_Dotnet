using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial { get; set; }
        private decimal precoPorHora { get; set; }
        private List<string?> veiculos = new List<string?>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a Placa do carro quer adicionar: ");
            veiculos.Add(Console.ReadLine()?.ToUpper());
            Console.WriteLine("Veículo adicionado!");
            
            Console.WriteLine($"Placa: {veiculos[veiculos.Count-1]}");


        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a Placa do carro quer remover: ");
            veiculos.Remove(Console.ReadLine()?.ToUpper());
            Console.WriteLine("Veículo removido!");
            Console.WriteLine();

            Console.WriteLine("Digite o tempo que o veículo ficou estacionado: ");
            decimal tempEstacionado = Convert.ToDecimal(Console.ReadLine());
            decimal pagamento = precoInicial + (precoPorHora*tempEstacionado);
            Console.WriteLine($"Valor do estacionamento foi:  R${pagamento}");
        }


        public void ListarVeiculos()
        {
            if (veiculos.Count != 0)
            {
                foreach (string? carros in veiculos)
                {
                    Console.WriteLine($"Placa: {carros}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados");
            }
        }



    }
}