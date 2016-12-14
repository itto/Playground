using System;
using Kristof.Kata.SecurityManagement.Kernel;

namespace Kristof.Kata.SecurityManagement.Numbers
{
    public class NumberAddedEvent : Event
    {
        public NumberAddedEvent(Guid id, int newValue)
        {
            NewValue = newValue;
            Id = id;
        }

        public Guid Id { get; }

        public int NewValue { get; }

        public override string ToString()
        {
            return "The number " + NewValue + " was added";
        }
    }
}