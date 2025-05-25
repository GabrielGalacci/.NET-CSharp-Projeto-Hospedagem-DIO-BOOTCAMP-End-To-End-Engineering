using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Gabriela", sobrenome: "Silva");
Pessoa p2 = new Pessoa(nome: "João", "Rodrigues");
Pessoa p3 = new Pessoa(sobrenome: "Rodrigues Silva", nome: "Laura");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium-Família", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor da Estadia ({reserva.DiasReservados} dias): {reserva.CalcularValorEstadia()}");