using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CsvHelper;
using FileHelpers;
using InvoiceTaxCalculator;


namespace FormatterSample
{
    public class Parser : IParser
    {
        GetValueFromParser getvalue=new GetValueFromParser();
        public void ParseToList(string filepath)
        {
            var engine = new FileHelperEngine<FileHelperModel>();
            getvalue.RetrieveResults(engine.ReadFile(filepath));
        }

    }
}
