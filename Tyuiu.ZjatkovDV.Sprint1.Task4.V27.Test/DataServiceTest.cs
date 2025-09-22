using Tyuiu.ZjatkovDV.Sprint1.Task4.V27.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task4.V27.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(-2.414, result.Calculate(1, 2));
        }
    }
}