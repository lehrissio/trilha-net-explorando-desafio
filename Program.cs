using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

bool continuar = true;

while (continuar)
{
    ExibirMenu();
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            CriarReserva();
            break;
        case "0":
            continuar = false;
            Console.WriteLine("Encerrando o sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            break;
    }

    if (continuar && opcao == "1")
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("═══════════════════════════════════════");
    Console.WriteLine("     SISTEMA DE HOSPEDAGEM HOTELEIRA    ");
    Console.WriteLine("═══════════════════════════════════════");
    Console.WriteLine();
    Console.WriteLine("1 - Criar Reserva");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();
    Console.Write("Escolha uma opção: ");
}

void CriarReserva()
{
    Console.Clear();
    Console.WriteLine("═══ CRIAR RESERVA ═══");
    Console.WriteLine();

    // Cria a suíte
    Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

    // Solicita quantidade de hóspedes
    Console.Write("Quantos hóspedes? ");
    int quantidadeHospedes = int.Parse(Console.ReadLine());

    // exceção
    if (quantidadeHospedes > suite.Capacidade)
    {
        throw new Exception($"Suite lotada! Capacidade da Suite é de {suite.Capacidade} hóspedes");
    }

    // Cria os hóspedes
    List<Pessoa> hospedes = new List<Pessoa>();
    
    for (int i = 1; i <= quantidadeHospedes; i++)
    {
        Console.Write($"Nome do hóspede {i}: ");
        string nome = Console.ReadLine();
        Console.Write($"Sobrenome do hóspede {i}: ");
        string sobrenome = Console.ReadLine();
        hospedes.Add(new Pessoa(nome: nome, sobrenome: sobrenome));
    }

    // Solicita quantidade de dias
    Console.Write("Quantos dias de hospedagem? ");
    int dias = int.Parse(Console.ReadLine());

    // Cria uma nova reserva
    Reserva reserva = new Reserva(diasReservados: dias);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe os resultados
    Console.WriteLine("\n═══ RESUMO DA RESERVA ═══");
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    
    Console.WriteLine("\nLista de hóspedes:");
    foreach (var hospede in reserva.Hospedes)
    {
        Console.WriteLine($"• {hospede.Nome} {hospede.Sobrenome}");
    }
    
    Console.WriteLine($"\nDias: {reserva.DiasReservados}");
    Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria():C}");
    
    if (dias >= 10)
    {
        Console.WriteLine("* Desconto de 10% aplicado!");
    }
}