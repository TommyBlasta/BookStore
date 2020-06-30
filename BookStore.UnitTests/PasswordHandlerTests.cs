using NUnit.Framework;
using BookStore;
using BookStore.Model;

namespace BookStore.UnitTests
{
    public class PasswordHandlerTests
    {
        private PasswordHandler _passHandler;

        [SetUp]
        public void Setup()
        {
            _passHandler = new PasswordHandler();
        }

        [Test]
        [TestCase("abc")]
        public void HashAndSaltPass_DefaultBehaviour_ReturnsTheCorrectHashAndSalt(string pass)
        {
            //Arrange
            //Act
            var result = _passHandler.HashAndSaltPass(pass);
            //Assert
            Assert.That(result,Is.Not.EqualTo(new HashWithSalt()));
        }
    }
}