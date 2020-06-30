using System;
using System.Collections.Generic;
using System.Text;
using BookStore.Converters;
using NUnit.Framework;

namespace BookStore.UnitTests
{
    class ByteConverterTests
    {
        private ByteConverter _byteConverter;

        [SetUp]
        public void Setup()
        {
            _byteConverter = new ByteConverter();
        }

        [Test]
        [TestCase("023")]
        public void ToByteArray_DefaultBehaviour_ReturnsStringAsByteArray(string str)
        {
            //Arrange
            //Act
            var result = _byteConverter.ToByteArray(str);
            //Assert
            Assert.That(result, Is.EqualTo(new byte[] { 48, 50, 51 }));
        }
        [Test]
        [TestCase(null)]
        public void ToByteArray_NullInput_ReturnsNull(string str)
        {
            //Arrange
            //Act
            var result = _byteConverter.ToByteArray(str);
            //Assert
            Assert.That(result, Is.EqualTo(null));
        }
        [Test]
        [TestCase(new byte[] { 48, 50, 51 })]
        public void ToString_DefaultBehaviour_ReturnsByteArrayFromString(byte[] byteArray)
        {
            //Arrange
            //Act
            var result = _byteConverter.ToString(byteArray);
            //Assert
            Assert.That(result, Is.EqualTo(new byte[] { 48, 50, 51 }));
        }

    }
}
