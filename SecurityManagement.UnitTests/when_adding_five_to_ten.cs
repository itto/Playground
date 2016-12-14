using System;
using System.Linq;
using Kristof.Kata.SecurityManagement.Numbers;
using Kristof.Kata.SecurityManagement.UnitTests.Kernel;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    public class when_adding_five_to_ten : AggregateTestFixture<Number>
    {
        private Guid id;

        protected override void When()
        {
            SystemUnderTest.Add(new Number(5));
        }

        protected override Number Given()
        {
            var number = new Number(10);
            this.id = number.Id;
            return number;
        }

        [Test]
        public void no_exception_is_thrown()
        {
            Assert.That(Caught, Is.Null);
        }

        [Test]
        public void the_result_is_fifteen()
        {
            var addedEvent = (NumberAddedEvent) PendingChanges.Single();

            Assert.That(addedEvent.Id, Is.EqualTo(this.id));
            Assert.That(addedEvent.NewValue, Is.EqualTo(15));
        }
    }
}