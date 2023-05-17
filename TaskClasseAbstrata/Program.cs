using System.Globalization;
using TaskClasseAbstrata.Entities;

List<Imposto> list = new List<Imposto>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char tipo = char.Parse(Console.ReadLine());
    Console.WriteLine("Name: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Anual income: ");
    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(tipo == 'i')
    {
        Console.WriteLine("Health expenditures: ");
        double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
    }
    else
    {
        Console.WriteLine("Number of employees: ");
        int numFuncionarios = int.Parse(Console.ReadLine());
        list.Add(new PessoaJuridica(nome, rendaAnual, numFuncionarios));
    }
}

double soma = 0.0;
Console.WriteLine();
Console.WriteLine("TAXES PAID: ");
foreach (Imposto imposto in list)
{
    double imp = imposto.ImpostoPago();
    Console.WriteLine(imposto.Nome + ": $ " + imp.ToString("F2", CultureInfo.InvariantCulture));
    soma += imp;
}
Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $" + soma.ToString("F2", CultureInfo.InvariantCulture));

