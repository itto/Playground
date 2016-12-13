namespace Kristof.Kata.SecurityManagement
{
    public class SecurityController
    {
        private readonly IUserManager _manager;
        private readonly IRepository _repository;

        public SecurityController(IRepository repository, IUserManager manager)
        {
            _repository = repository;
            _manager = manager;
        }
    }

    public interface IRepository
    {
    }

    public interface IUserManager
    {
    }
}