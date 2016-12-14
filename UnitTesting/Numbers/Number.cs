using Kristof.Kata.SecurityManagement.Kernel;

namespace Kristof.Kata.SecurityManagement.Numbers
{
    public class Number : Aggregate
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public void Add(Number number)
        {
            _value += number._value;
            AddEvent(new NumberAddedEvent(Id, _value));
        }
    }
}