namespace LambdaAnnotationsSample
{
    public interface ICalculatorService
    {
        int Add(int x, int y);
        int Substract(int x, int y);
    }

    public class CalculatorService : ICalculatorService
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }
    }
}