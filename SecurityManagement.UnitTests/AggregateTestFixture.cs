using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    [TestFixture]
    public abstract class AggregateTestFixture<T> where T : Aggregate
    {
        [SetUp]
        public void Setup()
        {
            try
            {
                caught = null;
                SystemUnderTest = Given();
                When();
                PendingChanges = new List<Event>(SystemUnderTest.GetPendingChanges());
            }
            catch (Exception ex)
            {
                caught = ex;
                throw;
            }
        }

        protected T SystemUnderTest;

        protected Exception caught;

        protected abstract void When();

        protected IEnumerable<Event> PendingChanges { get; set; }

        protected abstract T Given();
    }
}