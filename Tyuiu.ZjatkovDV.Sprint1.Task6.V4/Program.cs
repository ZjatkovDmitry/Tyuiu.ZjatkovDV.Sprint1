using System.Text;
using Tyuiu.ZjatkovDV.Sprint1.Task6.V4.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #1 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками класс String                                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу: пользователь вводит текст. Напечатать все  *");
Console.WriteLine("* слова, содержащие удвоенное н (\"нн\").                                   *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("Текст = ");
string x = Console.ReadLine();

Console.WriteLine(new string('*', 75));
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.CheckDoubleN(x));

Console.WriteLine(new string('*', 75));
Console.ReadKey();