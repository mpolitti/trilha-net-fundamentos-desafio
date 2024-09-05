namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {

            string placa = "";

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();

            if (placa == "") {
                Console.WriteLine("Placa inválida!");
            } else if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
                Console.WriteLine($"Placa {placa} já cadastrada!");
            } else {
                veiculos.Add(placa);
                Console.WriteLine($"Placa {placa} cadastrada com sucesso!");                
            }

        }

        public void RemoverVeiculo()
        {
            
            string placa = "";
            
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                
                //int horas = 0;
                decimal valorTotal = 0;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (!(int.TryParse(Console.ReadLine(), out int horas))) {
                 
                    Console.WriteLine("Horas inválidas!");

                } else {
                
                    valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                }

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string e in veiculos) {
                    Console.WriteLine(e);
                }                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
