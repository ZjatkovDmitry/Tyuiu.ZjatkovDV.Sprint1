using System.Text;
using Tyuiu.ZjatkovDV.Sprint1.Task5.V2.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #1 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая решает следующую задачу:           *");
Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому с       *");
Console.WriteLine("* помощью класса Convert.                                                 *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("Температура в Фарингейтах = ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.FahrenheitToСelsius(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();