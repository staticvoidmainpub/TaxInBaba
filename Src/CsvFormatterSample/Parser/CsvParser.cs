using System;
using FileHelpers;
using InvoiceTaxCalculator;
using Model;

namespace FormatterSample.Parser
{
    public class Parser : IParser
    {
        public ITaxCalculatorFactory ItaxCalculatiorFactory;

        public Parser(ITaxCalculatorFactory itaxCalculatorFactory)
        {
            this.ItaxCalculatiorFactory = itaxCalculatorFactory;
        }
        
        public void ParseToList(string filepath)
        {
            try
            {
                var engine = new FileHelperEngine<FileHelperModel>();
                ItaxCalculatiorFactory.CreateInstance(engine.ReadFile(filepath));
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine("{0}",ex.Message);
            }
        }

    }
}
