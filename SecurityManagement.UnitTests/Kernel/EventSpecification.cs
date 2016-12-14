using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Kristof.Kata.SecurityManagement.Kernel;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests.Kernel
{
    [TestFixture]
    public abstract class EventSpecification<TCommand> where TCommand : class, ICommand
    {
        protected Exception Caught;
        protected FakeEventStore FakeStore;
        public abstract IEnumerable<IEvent> Given();
        public abstract TCommand When();
        public abstract ICommandHandler<TCommand> OnHandler();
        public abstract IEnumerable<IEvent> Expect();

        private static void CompareEvents(IReadOnlyList<IEvent> expected, List<IEvent> produced)
        {
            // recursive, with reflection compare all fields and subevents
            for (var index = 0; index < expected.Count; index++)
            {
                var expectedEvent = expected[index];
                var producedEvent = produced[index];
                var type = expectedEvent.GetType();
                var unequalProperties =
                    from pi in type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    let selfValue = type.GetProperty(pi.Name).GetValue(expected, null)
                    let toValue = type.GetProperty(pi.Name).GetValue(producedEvent, null)
                    where (selfValue != toValue) && ((selfValue == null) || !selfValue.Equals(toValue))
                    select selfValue;

                if (unequalProperties.Any())
                    throw new Exception("Events are not the same");
            }
        }

        [Test]
        public void Setup()
        {
            Caught = null;
            FakeStore = new FakeEventStore(Given());
            var handler = OnHandler();
            try
            {
                handler.Handle(When());
                var produced = FakeStore.PeekChanges().ToList();
                var expected = Expect().ToList();
                CompareEvents(expected, produced);
            }
            catch (Exception exception)
            {
                Caught = exception;
            }

            Assert.That(Caught, Is.Null);
        }
    }
}