namespace CalculatorLibUnitTest
{
    using CalculatorLib;
    public class CalculatorUnitTest
    {
        [Fact]
        public void Test1()
        {
            double a = 2;
            double b = 2;
            double excepted = 4;
            Calculator calc = new();

            double actual = calc.Add(a, b);

            Assert.Equal(excepted , actual);
        }
        [Fact]
        public void Test2() 
        {
            double a = 2;
            double b = 3;
            double excepted = 5;
            Calculator calc = new();

            double actual = calc.Add(a , b);

            Assert.Equal (excepted , actual);
        }
    }
}
