using Moq;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    [TestFixture]
    public class SecurityControllerTestFixture
    {
        [Test]
        public void Method_Condition_ShouldExpected()
        {
            // Arrange
            var repo = new Mock<IRepository>();
            var userManager = new Mock<IUserManager>();
            var controller = new SecurityControllerBuilder()
                .WithRepository(repo.Object)
                .WithUserManager(userManager.Object)
                .Build();

            // Act


            // Assert
        }
    }


    public class SecurityControllerBuilder

    {
        private IRepository _repository;
        private IUserManager _userManager;

        public SecurityControllerBuilder()
        {
            _repository = new Mock<IRepository>().Object;
            _userManager = new Mock<IUserManager>().Object;
        }

        public SecurityControllerBuilder WithRepository(IRepository newRepository)
        {
            _repository = newRepository;
            return this;
        }

        public SecurityControllerBuilder WithUserManager(IUserManager newUserManager)
        {
            _userManager = newUserManager;
            return this;
        }

        public SecurityController Build()
        {
            return new SecurityController(_repository, _userManager);
        }
    }
}