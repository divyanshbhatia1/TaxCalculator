using TaxCalculator.App.Models;

namespace TaxCalculator.App.Data;

public static class TaxSlabs
{
    public static List<TaxSlab> OldRegimeSlabs = new List<TaxSlab>
            {
                new TaxSlab(0,250000,0),
                new TaxSlab(250000,500000,5),
                new TaxSlab(500000,1000000,20),
                new TaxSlab(1000000, decimal.MaxValue,30),
            };

    public static List<TaxSlab> NewRegimeSlabs = new List<TaxSlab>
            {
                new TaxSlab(0,250000,0),
                new TaxSlab(250000,500000,5),
                new TaxSlab(500000,750000,10),
                new TaxSlab(750000,1000000,15),
                new TaxSlab(1000000,1250000,20),
                new TaxSlab(1250000,1500000,25),
                new TaxSlab(1500000,decimal.MaxValue,30),
            };
}