//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cab_Invoice_Generator;
using NUnit.Framework;
//using System;


namespace CabTesting
{
   
    public class UnitTest1
    {

        public InvoiceGenerator invoiceGenerator;
        [SetUp]
        public void Setup()
        {
            invoiceGenerator = new InvoiceGenerator();
        }

        [Test]
        public void givenDistanceAndTime_WhenToCalculateFare_ShouldReturnFare()
        {
            double fare = invoiceGenerator.GenerateFare(2, 5);
            Assert.AreEqual(25, fare);
        }

        [Test]
        public void givenDistanceAndTime_WhenToCalculateMinimumFare_ShouldReturnMinimumFare()
        {
            double fare = invoiceGenerator.GenerateFare(0, 0);
            Assert.AreEqual(5, fare);
        }
        [Test]
        public void GivenDistanceAndTime_WhenToCalculateForMultipleFare_ShouldReturnAverageFare()
        {
            invoiceGenerator.AddRide(2, 5);
            invoiceGenerator.AddRide(12, 15);
            double fair = invoiceGenerator.CalculateAggregate();
            Assert.AreEqual(160, fair);
        }
    }
}