using System;
using FileHelpers;

namespace Model
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
