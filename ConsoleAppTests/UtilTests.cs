using Xunit;

namespace ConsoleApp.Tests
{
    public class UtilTests
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        public void AddTest(double x, double y, double expected)
        {
            double actual = Util.Add(x, y);

            Assert.Equal(expected, actual);
        }
    }
}