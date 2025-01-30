using System;
using System.Collections.Generic;
using Xunit;

namespace Mathmatics.Test
{
    public class AdvMathTest : IClassFixture<AdvMathTestFixture>
    {
        private AdvMathTestFixture _fixture;

        public AdvMathTest(AdvMathTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test_CalculateArea()
        {
            double result = _fixture.TestObject.CalculateArea(5, 10);
            Assert.Equal(50, result);
        }

        [Fact]
        public void Test_CalculateAverage()
        {
            List<double> numbers = new List<double> { 10, 20, 30, 40 };
            double result = _fixture.TestObject.CalculateAverage(numbers);
            Assert.Equal(25, result);
        }

        [Fact]
        public void Test_CalculateSquared()
        {
            double result = _fixture.TestObject.CalculateSquared(4);
            Assert.Equal(16, result);
        }
        
        [Fact]
        public void Test_CalculateHypotenuse()
        {
            double result = _fixture.TestObject.CalculateHypotenuse(3, 4);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test_CalculateAverage_EmptyList_ThrowsException()
        {
            List<double> emptyList = new List<double>();
            Assert.Throws<ArgumentException>(() => _fixture.TestObject.CalculateAverage(emptyList));
        }
    }
}
