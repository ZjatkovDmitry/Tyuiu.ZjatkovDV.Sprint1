using Tyuiu.ZjatkovDV.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task3.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckIncomeAmount()
        {
            var result = new DataService();
            Assert.Equal(41.096, result.IncomeAmount(2500, 20, 30));
        }
    }
}