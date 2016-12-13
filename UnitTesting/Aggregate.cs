using System;
using System.Collections.Generic;

namespace Kristof.Kata.SecurityManagement
{
    public abstract class Aggregate
    {
        private readonly List<Event> _events = new List<Event>();

        protected Aggregate() : this(Guid.NewGuid())
        {
        }

        protected Aggregate(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }

        protected void AddEvent(Event e)
        {
            _events.Add(e);
        }

        public IEnumerable<Event> GetPendingChanges()
        {
            return _events;
        }
    }

    public class Event
    {
    }
}