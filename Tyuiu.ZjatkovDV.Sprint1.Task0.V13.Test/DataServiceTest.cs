using Tyuiu.ZjatkovDV.Sprint1.Task0.V13.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task0.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(1, result.Calculate());
        }
    }
}