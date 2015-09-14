using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace InvoiceTaxCalculator.InternationalInvoice
{
    class GetInternationalInvoice : BaseTax
    {
        readonly ForeignRemittanceTax _foreignRemittanceTax = new ForeignRemittanceTax();

        public override TaxModel[] RetrieveResults(FileHelperModel[] file)
        {
            TaxModel[] domesticList = file.Where(s => s.EmpId.StartsWith("I"))
                .Select(l => new TaxModel() { DateTime = l.DateTime, Id = l.Id, EmpId = l.EmpId, Invoice = l.Invoice, ServiceTax = 0, EducationalCess = 0, ForeignRemittanceTax = 0 })
                .ToArray();

            var groupedQuery =
                domesticList.GroupBy(g => new { month = g.DateTime.Month, year = g.DateTime.Year })
                    .Select(
                        l =>
                            new
                            {
                                Invoice = l.Sum(I => I.Invoice),
                                Date = string.Format("{0}-{1}", l.Key.month, l.Key.year)
                            })
                    .OrderBy(a => a.Date)
                    .ToList();

            domesticList =
                groupedQuery.Select(
                    variable =>
                        new TaxModel()
                        {
                            DateTime = Convert.ToDateTime(variable.Date),
                            Invoice = variable.Invoice,
                            EmpId = null,
                            Id = (int)0,
                            ServiceTax = (int)0,
                            EducationalCess = (int)0
                        }).ToArray();
            return _foreignRemittanceTax.RetrieveResults(domesticList);
        }
    }
}
