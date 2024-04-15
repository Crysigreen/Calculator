namespace Сalculator.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }
    }
}
