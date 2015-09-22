using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceTaxCalculator.DomesticInvoice;
using Model;

namespace InvoiceTaxCalculator.InternationalInvoice
{
    public class ForeignRemittanceTax
    {
        TaxSummary taxSummary=new TaxSummary();
            
            internal TaxModel[] RetrieveResults(TaxModel[] file,TaxModel[] taxModels)
            {
 	            TaxModel[] international=file
                            .Select(
                                l =>
                                    new TaxModel()
                                    {
                                        DateTime = l.DateTime,
                                        Invoice = (l.Invoice),
                                        EmpId = null,
                                        Id = (int) 0,
                                        ServiceTax = (int) 0,
                                        EducationalCess = (int) 0,
                                        ForeignRemittanceTax = (l.Invoice*0.05)
                                    })
                            .ToArray();
                TaxModel[] domestic = taxModels.Select(
                        l =>
                            new TaxModel()
                            {
                                DateTime = l.DateTime,
                                Invoice = l.Invoice,
                                EducationalCess = l.EducationalCess,
                                EmpId = l.EmpId,
                                ForeignRemittanceTax = l.ForeignRemittanceTax,
                                Id = l.Id,
                                ServiceTax = l.ServiceTax
                            }).ToArray();

                TaxModel[] result = international.Concat(domestic).ToArray();
                OutputModel[] displayResult =
                    result.GroupBy(g => new {g.DateTime})
                        .Select(
                            group =>
                                new OutputModel()
                                {
                                    datetime = group.Key.DateTime,
                                    invoice = group.Sum(i => i.Invoice),
                                    serviceTax = Math.Ceiling(group.Sum(s => s.ServiceTax)),
                                    educationalCess = Math.Ceiling(group.Sum(e => e.EducationalCess)),
                                    foreignRemittanceCess = Math.Ceiling(group.Sum(frt => frt.ForeignRemittanceTax))
                                })
                        .ToArray();
                return taxSummary.SumArrays(displayResult);
            }
    }
}
