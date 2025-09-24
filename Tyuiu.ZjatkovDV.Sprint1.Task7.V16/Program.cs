using System.Text;
using Tyuiu.ZjatkovDV.Sprint1.Task7.V16.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #1 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет математическое выражение *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем. Ответ округлите   *");
Console.WriteLine("* до 3 знаков после запятой.                                              *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: z = sin√x^2 + cosx^2 / 3x^2 - sin√(x^2 - 1)            *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();