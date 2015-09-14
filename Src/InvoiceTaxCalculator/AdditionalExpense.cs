using InvoiceTaxCalculator.DomesticInvoice;

namespace InvoiceTaxCalculator
{
    public abstract class AdditionalExpense : GetDomesticInvoice
    {
        protected GetDomesticInvoice GetInvoiceObj { get; set; }

        protected AdditionalExpense(GetDomesticInvoice getDomesticInvoiceObjValue)
        {
            GetInvoiceObj = getDomesticInvoiceObjValue;
        }
    }
}
