using Tyuiu.ZjatkovDV.Sprint1.Task0.V13.Lib;

Console.Title = "Спринт #1 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет выражение                *");
Console.WriteLine("* 24/(6*2)-24/6/4 и печатает результат на экране.                         *");
Console.WriteLine("* одинаковых массивов по длине.                                           *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: 24/(6*2)-24/6/4                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(result.Calculate().ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();