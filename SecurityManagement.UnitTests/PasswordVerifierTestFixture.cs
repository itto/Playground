using System;
using NUnit.Framework;

namespace Kristof.Kata.SecurityManagement.UnitTests
{
    [TestFixture]
    public class PasswordVerifierTestFixture
    {
        [Test]
        public void Verify_PasswordHasNoCapital_ShouldThrow()
        {
            var sut = new PasswordVerifier();

            var exception = Assert.Throws<ArgumentException>(() => sut.Verify("abcdefghij"));
            Assert.That(exception.Message, Does.StartWith("Should contain uppercase"));
        }

        [Test]
        public void Verify_PasswordHasNoLowerCase_ShouldThrow()
        {
            var sut = new PasswordVerifier();

            var exception = Assert.Throws<ArgumentException>(() => sut.Verify("ABCDEFGHIJ"));
            Assert.That(exception.Message, Does.StartWith("Should contain lowercase"));
        }


        [Test]
        public void Verify_PasswordHasNoNumber_ShouldThrow()
        {
            var sut = new PasswordVerifier();

            var exception = Assert.Throws<ArgumentException>(() => sut.Verify("ABcDEFGHIJ"));
            Assert.That(exception.Message, Does.StartWith("Should contain at least one number"));
        }

        /*
 * 
 * Create a Password verifications class called “PasswordVerifier”.
Add the following verifications to a master function called “Verify()”

- password should be larger than 8 chars

- password should not be null

- password should have one uppercase letter at least

- password should have one lowercase letter at least

- password should have one number at least

Each one of these should throw an exception with a different message of your choosing

2. Add feature: Password is OK if at least three of the previous conditions is true

3. Add feature: password is never OK if item 1.4 is not true.

8. Assume Each verification takes 1 second to complete. How would you solve  items 2 and 3  so tests can run faster?


*/

        //[Test]
        //public void Verify_PasswordIs8Long_ShouldReturnTrue()
        //{
        //    var sut = new PasswordVerifier();

        //    var result = sut.Verify(@"Abcdefghi");

        //    Assert.That(result, Is.True);
        //}

        [Test]
        public void Verify_ThreeOk_ShouldReturnTrue()
        {
            var sut = new PasswordVerifier();

            var result = sut.Verify("Abcdefgh1");

            Assert.IsTrue(result);
        }

        [Test]
        public void Verify_PasswordIsNull_ShouldThrow()
        {
            var sut = new PasswordVerifier();

            var exception = Assert.Throws<ArgumentException>(() => sut.Verify(null));

            Assert.That(exception.Message, Does.StartWith("Value cannot be null."));
        }

        [Test]
        public void Verify_PasswordNotEightLong_ShouldThrow()
        {
            var sut = new PasswordVerifier();

            var exception = Assert.Throws<ArgumentException>(() => sut.Verify("abc"));
            Assert.That(exception.Message, Does.StartWith("Not long enough"));
        }
    }
}