using LogicalProblems;

namespace TestForLogicalProblem
{
    [TestClass]
    public class UnitTestingForLogical
    {

        LogicalProgram logicalProgram;

        [TestInitialize]
        public void Setup()
        {
            logicalProgram = new LogicalProgram();
        }

        [TestMethod]
        [DataRow(8, 21)]
        public void Fibonacci_WhenGivenNumberForFibonacci_ReturnsLastFibonacciNumber(int number, int expected)
        {
               int result = logicalProgram.fibonacciSeries(number);

                Assert.AreEqual(expected, result);
        
        }

        [TestMethod]
        [DataRow(6, true)]
        public void PerfectNumber_WhenNumberIsGiven_ReturnsTrueAndFalseForPerfectNumber(int number, bool expected)
        {
            bool result = logicalProgram.perfectNumber(number);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(6, false)]
        public int PrimeNumber_WhenNumberIsGiven_ReturnsTrueAndFalseForPrimeNumber(int number, bool expected)
        {
            bool result = logicalProgram.primeNumber(number);

            Assert.AreEqual(expected, result);
            return result ? 1 : 0;
        }

        [TestMethod]
        [DataRow(1234, 4321)]
         public void ReverseNumber_WhenNumberIsGiven_ReturnsReverseNumber(int number, int expected)
        {
            int result = logicalProgram.ReverseNumber(number);

            Assert.AreEqual(expected, result);
        }

    }
}