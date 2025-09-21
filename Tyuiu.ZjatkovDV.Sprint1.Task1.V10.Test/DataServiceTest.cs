using Tyuiu.ZjatkovDV.Sprint1.Task1.V10.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task1.V10.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(1.5, result.Calculate(1, 2));
        }
    }
}