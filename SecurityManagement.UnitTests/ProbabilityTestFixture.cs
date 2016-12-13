using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    /*
        Probability CombinedWith(Probability)
        Probability InverseOf(Probability)
        Probability Either(Probability)

        if you forget your probability math:
           Either:P(A) + P(B) - P(A)P(B)
           CombinedWith: P(A)P(B)
           InverseOf: 1 - P(A)

        The math is surprisingly not the main part of the exercise.

        The internal state should be held as a decimal. Use TDD when writing this object.

        One last thing. You can't put any getters on the object. When finished continue reading: https://gist.github.com/1018566
        */


    [TestFixture]
    public class ProbabilityTestFixture
    {
        [Test]
        [TestCase(1, 1, "1,00")]
        [TestCase(0.5, 0.5, "0,25")]
        public void Method_Condition_ShouldExpected(double inputOne, double inputTwo, string result)
        {
            // Arrange
            var probabilityOfOne = new Probability(new decimal(inputOne));

            // Act
            var prob = probabilityOfOne.CombinedWith(new Probability(new decimal(inputTwo)));

            // Assert
            Assert.That(prob.ToString(), Is.EqualTo(result));
        }
    }
}