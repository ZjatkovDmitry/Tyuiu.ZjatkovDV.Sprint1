using Tyuiu.ZjatkovDV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task5.V2.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckConvertor()
        {
            var result = new DataService();
            Assert.Equal(0, result.FahrenheitTo—elsius(32));
        }
    }
}