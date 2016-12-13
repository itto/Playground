using System.Linq;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    public class when_adding_five_to_ten : AggregateTestFixture<Number>
    {
        protected override void When()
        {
            SystemUnderTest.Add(new Number(5));
        }

        protected override Number Given()
        {
            return new Number(10);
        }

        [Test]
        public void no_exception_is_thrown()
        {
            Assert.That(caught, Is.Null);
        }

        [Test]
        public void the_result_is_fifteen()
        {
            Assert.That(((NumberAddedEvent) PendingChanges.Single()).NewValue, Is.EqualTo(15));
        }
    }
}