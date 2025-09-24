using Tyuiu.ZjatkovDV.Sprint1.Task6.V4.Lib;

namespace Tyuiu.ZjatkovDV.Sprint1.Task6.V4.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCheckDoubleN()
        {
            var result = new DataService();
            Assert.Equal("деревянную", result.CheckDoubleN("Привет, заверши эту деревянную скульптуру к обеду."));
        }
    }
}