namespace TaxCalculator.App.Models;

public class TaxSlab
{
    public TaxSlab(decimal from, decimal to, decimal rate)
    {
        From = from;
        To = to;
        Rate = rate;
    }

    public decimal From { get; set; }
    public decimal To { get; set; }
    public decimal Rate { get; set; }
    private decimal MaxTax => (To - From) * Rate / 100;
    public decimal TaxApplied(decimal amount)
    {
        if (amount < From) return 0;

        if (amount >= To) return MaxTax;

        return (amount - From) * Rate / 100;
    }
}