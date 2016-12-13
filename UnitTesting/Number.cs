namespace Kristof.Kata.SecurityManagement
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
            AddEvent(new NumberAddedEvent(_value));
        }
    }
}