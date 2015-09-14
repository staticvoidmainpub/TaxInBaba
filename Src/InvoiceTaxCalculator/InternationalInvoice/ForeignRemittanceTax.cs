using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace InvoiceTaxCalculator.InternationalInvoice
{
    public class ForeignRemittanceTax
    {
        public TaxModel[] RetrieveResults(TaxModel[] file)
        {
            return file
                .Select(l => new TaxModel() { DateTime = l.DateTime, Invoice = (l.Invoice), EmpId = null, Id = (int)0,ServiceTax = (int)0,EducationalCess = (int)0,ForeignRemittanceTax = (l.Invoice*0.05)})
                .ToArray();
        }
    }
}
