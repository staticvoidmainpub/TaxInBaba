using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace InvoiceTaxCalculator.DomesticInvoice
{
    public class EducationCess
    {
        public TaxModel[] RetrieveResults(TaxModel[] file)
        {
            var s= file
                .Select(l => new TaxModel() { DateTime = l.DateTime, Invoice = l.Invoice, EmpId = null, Id = (int)0,ServiceTax = l.ServiceTax,EducationalCess = (l.Invoice*0.03),ForeignRemittanceTax = (int)0})
                .ToArray();
            return s;
        }
    }
}
