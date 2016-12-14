using Kristof.Kata.SecurityManagement.Kernel;
using Kristof.Kata.SecurityManagement.Numbers;
using Kristof.Kata.SecurityManagement.UnitTests.Kernel;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    internal class AddNumberCommandHandler : ICommandHandler<AddNumberCommand>
    {
        private readonly FakeEventStore _fakeStore;

        public AddNumberCommandHandler(FakeEventStore fakeStore)
        {
            _fakeStore = fakeStore;
        }

        public void Handle(AddNumberCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}