using CommandLine;
using TaxCalculator.App;
using TaxCalculator.App.Calculator;
using TaxCalculator.App.Data;

Parser.Default.ParseArguments<Options>(args)
           .WithParsed(o =>
           {
               var slabs = o.IsOldRegime ? TaxSlabs.OldRegimeSlabs : TaxSlabs.NewRegimeSlabs;

               IIncomeTaxCalculator taxCalculator = new IncomeTaxCalculator(slabs);

               var tax = taxCalculator.CalculateIncomeTax(o.Amount);

               Console.WriteLine($"Income Tax: {tax}");
           });
