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
}