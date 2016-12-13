namespace Kristof.Kata.SecurityManagement
{
    public class NumberAddedEvent : Event
    {
        public NumberAddedEvent(int newValue)
        {
            NewValue = newValue;
        }

        public int NewValue { get; }
    }
}