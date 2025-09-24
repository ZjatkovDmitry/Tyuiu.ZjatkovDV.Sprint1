using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZjatkovDV.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string result = "";
            foreach (string item in value.Split(' '))
            {
                if (item.Contains("нн"))
                    result += item + ' ';
            }

            return result.Trim();
        }
    }
}
