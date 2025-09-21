using Tyuiu.ZjatkovDV.Sprint1.Task1.V10.Lib;

Console.Title = "Спринт #1 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая запрашивает у пользователя         *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле (x+y)/(1+x) и печатает  *");
Console.WriteLine("* его на экране.                                                          *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: (x+y)/(1+x)                                            *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(result.Calculate(x, y).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();
