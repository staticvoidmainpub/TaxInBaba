using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace InvoiceTaxCalculator
{
    public interface ITaxSummary
    {
        TaxModel[] SumArrays(OutputModel[] taxModels);

        
    }
}
