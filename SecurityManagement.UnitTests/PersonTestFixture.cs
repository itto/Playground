using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    [TestFixture]
    public class PersonTestFixture
    {
        [Test]
        public void GetSalary_Salary100_ShouldReturn500()
        {
            // Arrange
            var person = new PersonBuilder().WithSalary(100).Build();
            // Act
            person.AddHoursWorked(8);

            // Assert
            Assert.That(person.GetSalary(), Is.EqualTo(800));
        }
    }
}