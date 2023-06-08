namespace LogicalProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to logical programs   ");
            LogicalProgram obj = new LogicalProgram();
            obj.fibonacciSeries(3);
            obj.perfectNumber(5);
            obj.primeNumber(7);
            obj.stopWatch();
            obj.ReverseNumber(123);
        }
    }
 }