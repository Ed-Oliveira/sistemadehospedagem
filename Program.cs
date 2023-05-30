using System.Text;
using projeto_Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hospedes e cadastra na lista de hospedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Carlos");
Pessoa p2 = new Pessoa(nome: "Maria");


hospedes.Add(p1);
hospedes.Add(p2);

//Cria a suite
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 10);

//Cria uma nova reserva passando a suite e os hospedes
Reserva reserva = new Reserva(diasReservados: 100);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hospedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria():C}");
