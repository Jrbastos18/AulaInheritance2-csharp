using System.Globalization;
using System.Collections.Generic;
using Aula146ExFxMetodosAbstratos.Entities;

namespace Aula146ExFxMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();//Estanciando a lista genérica da classe abstrata

            Console.Write("Enter the number os tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')//Condição para individual
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else//Condição para company
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }

            }

            double totalTaxes = 0.0;//Declarando uma váriavel para somátório dos impostos
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tp in list) //Percorrendo a lista de classes de forma polimórfica 
            {
                Console.WriteLine(tp.Name + ": $" + tp.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += tp.Tax();//Somatório dos impostos dentro do foreach
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}