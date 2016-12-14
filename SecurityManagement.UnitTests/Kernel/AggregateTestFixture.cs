using System;
using System.Collections.Generic;
using Kristof.Kata.SecurityManagement.Kernel;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests.Kernel
{
    [TestFixture]
    public abstract class AggregateTestFixture<T> where T : Aggregate
    {
        [SetUp]
        public void Setup()
        {
            try
            {
                Caught = null;
                SystemUnderTest = Given();
                When();
                PendingChanges = new List<Event>(SystemUnderTest.GetPendingChanges());
            }
            catch (Exception ex)
            {
                Caught = ex;
                throw;
            }
        }

        protected T SystemUnderTest;

        protected Exception Caught;

        protected abstract void When();

        protected IEnumerable<Event> PendingChanges { get; set; }

        protected abstract T Given();
    }
}