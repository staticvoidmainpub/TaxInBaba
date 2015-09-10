using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormatterSample;

namespace InvoiceTaxCalculator
{
    public class GetValueFromParser
    {

        private FileHelperModel[] DomesticList,InternationalList; 
        public void RetrieveResults(FileHelperModel[] file)
        {
            foreach (var InvoiceSeparator in file)
            {
                DomesticList = file.Where(s => s.EmpId.StartsWith("D")).ToArray();
                InternationalList = file.Where(s => s.EmpId.Contains("I")).ToArray();
            }
            
        }

    }
    
}
