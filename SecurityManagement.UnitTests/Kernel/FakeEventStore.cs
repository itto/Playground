using System;
using System.Collections.Generic;
using Kristof.Kata.SecurityManagement.Kernel;

namespace Kristof.Kata.SecurityManagement.UnitTests.Kernel
{
    public class FakeEventStore
    {
        private readonly List<IEvent> _events;

        public FakeEventStore(IEnumerable<IEvent> events)
        {
            _events = new List<IEvent>(events);
        }

        public IEnumerable<IEvent> PeekChanges()
        {
            throw new NotImplementedException();
        }
    }
}