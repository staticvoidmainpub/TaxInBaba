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
        public FileHelperModel[] RetrieveResults(FileHelperModel[] file)
        {
            return file.Select(l => new FileHelperModel() { DateTime = l.DateTime, Invoice = (l.Invoice * 1.03), EmpId = null, Id = (int)0 }).ToArray();
        }
    }
}
