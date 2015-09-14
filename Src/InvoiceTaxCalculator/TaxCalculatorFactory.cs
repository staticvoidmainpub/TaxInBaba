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
            var getDomesticInvoice=new GetDomesticInvoice();
            getDomesticInvoice.RetrieveResults(file);
            
            var getInternationalInvoice=new GetInternationalInvoice();
            getInternationalInvoice.RetrieveResults(file);
        }

    }
    
}
