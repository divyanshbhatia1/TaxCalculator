using CommandLine;
using TaxCalculator.App.Calculator;
using TaxCalculator.App.Data;

namespace TaxCalculator.App;

public class Program
{
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(o =>
            {
                var slabs = o.IsOldRegime ? TaxSlabs.OldRegimeSlabs : TaxSlabs.NewRegimeSlabs;

                ITaxCalculator taxCalculator = new Calculator.TaxCalculator(slabs);

                var tax = taxCalculator.CalculateIncomeTax(o.Amount);

                Console.WriteLine($"Income Tax: {tax}");
            });
    }
}
