using System;
using InvoiceTaxCalculator.DomesticInvoice;
using Model;
using NUnit.Framework;

namespace InvoiceTaxCalculator.Tests
{
    [TestFixture]
    public class InvoiceTaxCalculatorTests
    {
        [Test]
        public void TestServiceTaxCalculation()
        {
            //In real world applications moq is used.
            var taxSummary=new TaxSummary();

            var testOutput=new TaxModel[2];
            testOutput[0]=new TaxModel
            {
                DateTime = Convert.ToDateTime(null),
                Invoice = 13000,
                ServiceTax = 0,
                EducationalCess = 0,
                ForeignRemittanceTax = 0
            };
            testOutput[1]=new TaxModel
            {
                DateTime = Convert.ToDateTime(null),
                Invoice = 1500,
                ServiceTax = 0,
                EducationalCess = 0,
                ForeignRemittanceTax = 0
            };


            var educationCess = new EducationCess();

            var result=educationCess.RetrieveResults(testOutput);

            foreach (var taxModel in result)
            {
                Assert.AreEqual(taxModel.ServiceTax,testOutput[0].ServiceTax,"The values are null");
            }

        }
    }
}
