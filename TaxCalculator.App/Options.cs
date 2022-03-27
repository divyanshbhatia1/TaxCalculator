using CommandLine;

namespace TaxCalculator.App;

public class Options
{
    [Option('o', "old", Required = false, HelpText = "To Calculate using old regime")]
    public bool IsOldRegime { get; set; }

    [Value(0, MetaName = "Amount", Required = true, HelpText = "Amount to calculate tax on.")]
    public decimal Amount { get; set; }
}