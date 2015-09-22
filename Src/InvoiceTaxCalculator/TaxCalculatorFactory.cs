using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceTaxCalculator.DomesticInvoice;
using InvoiceTaxCalculator.InternationalInvoice;
using Model;

namespace InvoiceTaxCalculator
{
    public class TaxCalculatorFactory : ITaxCalculatorFactory
    {
        public void CreateInstance(FileHelperModel[] file)
        {
            var getInternationalInvoice=new GetInternationalInvoice();
            getInternationalInvoice.RetrieveResults(file);
        }

    }
    
}
