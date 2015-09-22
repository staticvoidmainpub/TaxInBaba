using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace InvoiceTaxCalculator
{
    public class TaxSummary : ITaxSummary
    {

        public TaxModel[] SumArrays(OutputModel[] displayResult)
        {
            Console.WriteLine("Month | Total Invoice Amount | ST | EC | FRT");
            foreach (var display in displayResult)
            {
                Console.WriteLine("{0}-{1}    {2}    {3}    {4}    {5}",display.datetime.Month,display.datetime.Year,display.invoice,display.serviceTax,display.educationalCess,display.foreignRemittanceCess);
            }

            IEnumerable<OutputModel> displayTotal = from p in displayResult
                group p by p.GetType()
                into g
                select new OutputModel
                {
                    datetime = Convert.ToDateTime(null),
                    invoice = g.Sum(i => i.invoice),
                    serviceTax = g.Sum(s => s.serviceTax),
                    educationalCess = g.Sum(e => e.educationalCess),
                    foreignRemittanceCess = g.Sum(frt => frt.foreignRemittanceCess)
                };

            foreach (var outputModel in displayTotal)
            {
            Console.WriteLine("\n\n--------------\nTOTAL :    {0}    {1}    {2}", outputModel.serviceTax, outputModel.educationalCess, outputModel.foreignRemittanceCess);    
            }
            

            return null;
            
        }
    }
}
