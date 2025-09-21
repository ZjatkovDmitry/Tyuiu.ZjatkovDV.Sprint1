using Tyuiu.ZjatkovDV.Sprint1.Task2.V8.Lib;

Console.Title = "Спринт #1 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая запрашивает у пользователя         *");
Console.WriteLine("* исходные данные, вычисляет периметр прямоугольника и печатает           *");
Console.WriteLine("* его на экране.                                                          *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(result.CalculatePerimetr(a, b).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();