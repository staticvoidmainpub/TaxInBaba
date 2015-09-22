using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace InvoiceTaxCalculator.DomesticInvoice
{
    public class ServiceTax
    {
        readonly EducationCess educationCess=new EducationCess();
        public TaxModel[] RetrieveResults(TaxModel[] file)
        {
            return educationCess
                .RetrieveResults(file.Select(l=>new TaxModel(){DateTime = l.DateTime,Invoice = (l.Invoice),EmpId = null,Id = (int)0,ServiceTax = (l.Invoice*0.1),EducationalCess = (int)0,ForeignRemittanceTax = (int)0})
                .ToArray());
        }
    }
}
