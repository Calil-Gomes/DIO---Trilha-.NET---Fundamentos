using System;
using DIO_Codigos.Models;


namespace DIO_Codigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esta();
        }
        static void Variavel()
        {
            Dictionary<string, List<int>> teste = new Dictionary<string, List<int>>();
            List<int> testeArray = new List<int>();

            for (int cont = 0; cont < 5; cont++)
            {
                testeArray.Add(cont);
            }
            teste.Add("Teste1", testeArray);
            //Console.WriteLine(string.Join(", ", testeArray));
            void Mostrar()
            {
                foreach (KeyValuePair<string, List<int>> item in teste)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(string.Join(", ", item.Value));
                    //Console.WriteLine(item);
                }
            }
            Mostrar();
        }
        static void Esta()
        {
            Console.WriteLine("            INICIANDO - GESTOR DE ESTACIONAMENTOS");
            Estacionamento novo = new Estacionamento();
            novo.precoInicial = 10;
            while (true)
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("   1 -> listar veículos");
                Console.WriteLine("   2 -> adicionar veículos");
                Console.WriteLine("   3 -> remover veículos");
                Console.WriteLine("   4 -> Sair do gerenciador");
                Console.WriteLine("   5 -> Alterar valor do preço inicial");
                string acionador = Console.ReadLine();
                int entrada;
                if (Int32.TryParse(acionador, out entrada))
                {
                    if (entrada == 1)
                    {
                        Console.WriteLine("Aqui estão todos os veículos cadastrados:");
                        novo.ListarVeiculosCadastrado();
                    }
                    else if (entrada == 2)
                    {
                        Console.WriteLine("Digite o nome do motorista");
                        string nomeMt = Console.ReadLine();
                        Console.WriteLine("Digite o modelo do veículo:");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Digite a placa do veículo:");
                        string placa = Console.ReadLine();
                        Console.WriteLine("Digite a idade do motorista:");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        novo.AdicionarVeiculo(nomeMt, idade, placa, modelo);
                    }
                    else if (entrada == 3)
                    {
                        Console.WriteLine("Digite o nome do motorista a ser removido do estacionamento:");
                        string nomeRemoverr = Console.ReadLine();
                        Console.WriteLine("Digite quantas horas o veículo permaneceu estacionado:");
                        decimal horasEstacionadas = Convert.ToDecimal(Console.ReadLine());
                        novo.RemoverVeiculo(nomeRemoverr, novo.precoInicial, horasEstacionadas);
                    }
                    else if (entrada == 4)
                    {
                        Console.WriteLine("Saindo...");
                        break;
                    }
                    else if (entrada == 5)
                    {
                        Console.WriteLine("Digite o novo valor:");
                        novo.precoInicial = Convert.ToDecimal(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Valor errado. Digite novamente");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Digite novamente");
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
        }
    }
}