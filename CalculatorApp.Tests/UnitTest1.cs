namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);

        }
    }
}