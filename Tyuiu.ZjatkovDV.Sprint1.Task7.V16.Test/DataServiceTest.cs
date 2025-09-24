using Tyuiu.ZjatkovDV.Sprint1.Task7.V16.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task7.V16.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(1.022, result.Calculate(1));
        }
    }
}