using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;


namespace FormatterSample
{
    [DelimitedRecord(", ")]
    public class FileHelperModel
    {
        public Int32 Id;

        public String EmpId;

        [FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
        public DateTime DateTime;

        public double Invoice;
    }
}
