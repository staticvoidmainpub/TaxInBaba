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
        public FileHelperModel[] RetrieveResults(FileHelperModel[] file)
        {
            var s= file.RetrieveResults(file.Select(l=>new FileHelperModel(){DateTime = l.DateTime,Invoice = (l.Invoice),EmpId = null,Id = (int)0}).ToArray());
            return s;
        }
    }
}
