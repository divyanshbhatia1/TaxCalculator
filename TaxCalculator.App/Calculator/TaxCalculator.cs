using TaxCalculator.App.Models;

namespace TaxCalculator.App.Calculator;

public class TaxCalculator : ITaxCalculator
{
    private readonly List<TaxSlab> _taxSlabs;
    public TaxCalculator(List<TaxSlab> taxSlabs)
    {
        _taxSlabs = taxSlabs;
    }

    public virtual decimal CalculateIncomeTax(decimal income)
    {
        var tax = _taxSlabs?.Sum(slab => slab.TaxApplied(income));
        return tax ?? 0;
    }
}
