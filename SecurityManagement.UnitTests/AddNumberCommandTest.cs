using System;
using System.Collections.Generic;
using Kristof.Kata.SecurityManagement.Kernel;
using Kristof.Kata.SecurityManagement.Numbers;
using Kristof.Kata.SecurityManagement.UnitTests.Kernel;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    [TestFixture]
    internal class WhenAddingANumber : EventSpecification<AddNumberCommand>
    {
        public override ICommandHandler<AddNumberCommand> OnHandler()
        {
            new TestFormatter().Print(this);
            return new AddNumberCommandHandler(FakeStore);
        }

        public override IEnumerable<IEvent> Expect()
        {
            yield return new NumberAddedEvent(Guid.NewGuid(), 15);
        }

        public override IEnumerable<IEvent> Given()
        {
            yield return new NumberCreatedEvent();
        }

        public override AddNumberCommand When()
        {
            return new AddNumberCommand(5);
        }
    }

    internal class NumberCreatedEvent : IEvent
    {
        public override string ToString()
        {
            return "A new number was created";
        }
    }
}