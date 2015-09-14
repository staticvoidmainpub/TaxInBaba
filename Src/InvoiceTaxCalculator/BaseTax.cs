using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace InvoiceTaxCalculator
{
    public abstract class BaseTax
    {
        public abstract TaxModel[] RetrieveResults(FileHelperModel[] file);

    }
}
