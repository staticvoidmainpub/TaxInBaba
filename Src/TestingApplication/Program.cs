using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormatterSample;
using FormatterSample.Parser;
using InvoiceTaxCalculator;

namespace TestingApplication
{
    class Program 
    {
        public static string Filepath { get; set; }
        static void Main(string[] args)
        {
            var parser=new Parser(new TaxCalculatorFactory());

            Filepath = args[0];
            parser.ParseToList(Filepath);

            Console.ReadLine();
        }

    }
}
