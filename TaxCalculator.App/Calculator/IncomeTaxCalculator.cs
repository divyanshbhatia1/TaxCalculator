using TaxCalculator.App.Models;

namespace TaxCalculator.App.Calculator;

public class IncomeTaxCalculator : IIncomeTaxCalculator
{
    private readonly List<TaxSlab> _taxSlabs;
    public IncomeTaxCalculator(List<TaxSlab> taxSlabs)
    {
        _taxSlabs = taxSlabs;
    }

    public virtual decimal CalculateIncomeTax(decimal income)
    {
        var tax = _taxSlabs?.Sum(slab => slab.TaxApplied(income));
        return tax ?? 0;
    }
}
