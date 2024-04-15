namespace Calculator.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(10.5, 2, 12.5)]
        public void Addition(double x, double y, double expected)
        {
            var service = new CalculatorService();
            var result = service.Addition(x, y);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10.5, 2, 8.5)]
        public void Subtraction(double x, double y, double expected)
        {
            var service = new CalculatorService();
            var result = service.Subtraction(x, y);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(10.5, 2, 21)]
        public void Multiplication(double x, double y, double expected)
        {

            var service = new CalculatorService();
            var result = service.Multiplication(x, y);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(10.5, 2, 5.25)]
        [InlineData(10.5, 0, 0)]
        public void Division(double x, double y, double expected)
        {
            var service = new CalculatorService();

            if (y == 0)
            {
                Assert.Throws<DivideByZeroException>(() => service.Divide(x, y));
            }
            else
            {
                var result = service.Divide(x, y);
                Assert.Equal(expected, result);
            }
        }
    }
}