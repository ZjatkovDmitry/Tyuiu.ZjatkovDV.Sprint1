using Tyuiu.ZjatkovDV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task2.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(6, result.CalculatePerimetr(1, 2));
        }
    }
}