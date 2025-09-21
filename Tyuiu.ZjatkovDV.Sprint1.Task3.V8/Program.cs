using Tyuiu.ZjatkovDV.Sprint1.Task3.V8.Lib;

Console.Title = "Спринт #1 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Написать программу вычисления величины дохода по вкладу.       *");
Console.WriteLine("* Процентная ставка (% годовых) и время хранения (дней) задаются во время *");
Console.WriteLine("* работы программы. Ответ округлить до 3 знаков после запятой.            *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

Console.Write("Процентная ставка (% годовых) = ");
int percent = Convert.ToInt32(Console.ReadLine());

Console.Write("Время хранения (дней) = ");
int timeDays = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма вклада = ");
int startAmount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(new string('*', 75));
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(result.IncomeAmount(startAmount, percent, timeDays).ToString() + " руб.");

Console.WriteLine(new string('*', 75));
Console.ReadKey();