using NUnit.Framework;

namespace ArabigosRomanos
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConversionFromBaseNumber()
        {
            var convertor = new NumberConvertor(); //Convertor class that have the method Convert(int number)
            string result = convertor.Convert(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        public void ConversionAtLimit()
        {
            var convertor = new NumberConvertor();
            string result = convertor.Convert(4);
            Assert.AreEqual("IV", result);
        }

        [Test]
        public void ComplicatedConvertion()
        {
            var convertor = new NumberConvertor();
            string result = convertor.Convert(49);
            Assert.AreEqual("XLIX", result);
        }

        [Test]
        public void ConversionWithNegative()
        {
            var convertor = new NumberConvertor();
            string result = convertor.Convert(-5);
            Assert.AreEqual("No se puede convertir un número no natural", result);
        }

        [Test]
        public void ConversionWithLargeNumbers()
        {
            var convertor = new NumberConvertor();
            string result = convertor.Convert(1151);
            Assert.AreEqual("MCLI", result);
        }
    }
}