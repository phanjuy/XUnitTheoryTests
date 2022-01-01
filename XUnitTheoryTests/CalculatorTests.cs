using Xunit;

namespace XUnitTheoryTests
{
    public class CalculatorTests
    {
        [Fact]
        public void CanAdd()
        {
            var calculator = new Calculator();

            int value1 = 1;
            int value2 = 2;

            var result = calculator.Add(value1, value2);

            Assert.Equal(3, result);
        }
    }
}
