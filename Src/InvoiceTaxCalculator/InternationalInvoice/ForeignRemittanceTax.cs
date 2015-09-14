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
        public FileHelperModel[] RetrieveResults(FileHelperModel[] file)
        {
            return file.Select(l => new FileHelperModel() { DateTime = l.DateTime, Invoice = (l.Invoice * 1.05), EmpId = null, Id = (int)0 }).ToArray();
        }
    }
}
