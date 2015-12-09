using Xunit;

namespace Fibonacci.Tests
{
    public class Tests
    {
        [Fact]
        public void Get_5th_number()
        {
            var generator = new FibonacciGenerator();

            Assert.Equal(generator.Fibonacci(5), 5);
        }

        [Fact]
        public void Get_6th_number()
        {
            var generator = new FibonacciGenerator();

            Assert.Equal(generator.Fibonacci(6), 8);
        }
    }
}
