﻿using InvoiceTaxCalculator.DomesticInvoice;
using InvoiceTaxCalculator.InternationalInvoice;

namespace InvoiceTaxCalculator
{
    public abstract class AdditionalExpense 
    {
        protected GetDomesticInvoice GetInvoiceObj { get; set; }

        protected AdditionalExpense(GetDomesticInvoice getDomesticInvoiceObjValue)
        {
            GetInvoiceObj = getDomesticInvoiceObjValue;
        }
    }
}
