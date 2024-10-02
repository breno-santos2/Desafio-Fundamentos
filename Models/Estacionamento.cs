namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {

#pragma warning disable IDE0052 // Remover membros particulares não lidos
        private readonly decimal precoInicial = 0;
#pragma warning restore IDE0052 // Remover membros particulares não lidos

#pragma warning disable IDE0052 // Remover membros particulares não lidos
        private readonly decimal precoPorHora = 0;
#pragma warning restore IDE0052 // Remover membros particulares não lidos
        private readonly List<string> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine($"Veículo com a placa {placa} adicionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();


            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (decimal.TryParse(Console.ReadLine(), out decimal horas) && horas >= 0)
                {
                    decimal valorPorHora = 10.00m;
                    decimal valorTotal = horas * valorPorHora;
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida. Por favor, insira um número válido.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }

}

