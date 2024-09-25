using Desafio_Estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \n" +
                    "Digite o valor inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite um número correspondente a ação que deseja: ");
    Console.WriteLine("1 - Adicionar Veiculos");
    Console.WriteLine("2 - Remover Veiculos");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            Console.WriteLine();
            break;

        case "2":
            es.RemoverVeiculo();
            Console.WriteLine();
            break;

        case "3":
            es.ListarCarros();
            Console.WriteLine();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Comando Inválido, tente novamente com os número da tabela");
            break;
    }
    Console.WriteLine("Digite qualquer tecla para continuar:");
    Console.ReadLine();
}
Console.WriteLine("Programa encerrado, até a proxima!");