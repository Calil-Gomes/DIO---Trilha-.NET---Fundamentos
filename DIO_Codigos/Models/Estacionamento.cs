using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DIO_Codigos.Models
{
    /// <summary>
    /// Classe para gerenciar veículos estacionados
    /// </summary>
    public class Estacionamento
    {
        /// <summary>
        /// Está é a lista que guardará todos os veículos estacionados.
        /// No projeto é pedido que tenha o nome "veiculos", porém foi usado esse nome.
        /// </summary>
        Dictionary<string, List<string>> cadastroMotoristaVeiculo = new Dictionary<string, List<string>>();
        
        int? idadeMotorista { get; set; }
        string? nomeMotorista { get; set; }
        string?  placaVeiculo { get; set; }
        string?  modeloVeiculo { get; set; }
        public decimal? precoInicial { get; set; }
        decimal? precoHora { get; set; }
        public void ListarVeiculosCadastrado(){
            if (cadastroMotoristaVeiculo.Count() == 0) {
                Console.WriteLine("Lista vazia");
            }
            else {
                foreach (KeyValuePair<string, List<string>> item in cadastroMotoristaVeiculo) {
                    Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)}");
                }
            }
        }
        public void AdicionarVeiculo(string nome, int idade, string placa, string veiculo){
            List<string> veiculosEstacionados = new List<string>();
            try {
                veiculosEstacionados.Add(veiculo);
                veiculosEstacionados.Add(placa);
                veiculosEstacionados.Add(Convert.ToString(idade));
                cadastroMotoristaVeiculo.Add(nome, veiculosEstacionados);
                Console.WriteLine("Cadastrado...");
            }catch{
                Console.WriteLine("Ocorreu um erro...");
            }  
        }
        public void RemoverVeiculo(string? nome,decimal? prec, decimal horas)
        {
            try
            {
                cadastroMotoristaVeiculo.Remove(nome);
                Console.WriteLine("Véiculo removido");
                Console.WriteLine($"Preço final pago: R${prec*horas}");
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro...");
            }
        }
    }
}
