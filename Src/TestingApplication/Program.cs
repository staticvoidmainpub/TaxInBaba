using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormatterSample;

namespace TestingApplication
{
    class Program
    {
        public static string filepath { get; set; }

        static void Main(string[] args)
        {
            Parser csvform=new Parser();
            filepath = args[0];
            csvform.ParseToList(filepath);

            //foreach (FileHelperModel VARIABLE in variable)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}",VARIABLE.Id,VARIABLE.DateTime,VARIABLE.EmpId,VARIABLE.Invoice);
            //}
            Console.ReadLine();
        }

        
    }
}
