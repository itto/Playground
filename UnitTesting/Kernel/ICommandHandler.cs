namespace Kristof.Kata.SecurityManagement.Kernel
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        void Handle(T command);
    }
}