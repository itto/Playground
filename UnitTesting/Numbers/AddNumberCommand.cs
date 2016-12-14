using Kristof.Kata.SecurityManagement.Kernel;

namespace Kristof.Kata.SecurityManagement.Numbers
{
    public class AddNumberCommand : ICommand
    {
        private readonly int _value;

        public AddNumberCommand(int value)
        {
            _value = value;
        }


        public override string ToString()
        {
            return "Adding the number " + _value;
        }
    }
}