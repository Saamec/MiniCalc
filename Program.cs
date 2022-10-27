
using MiniCalc;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

int value1 = 0;
int value2 = 0;
Console.WriteLine("Введите 2 числа");
try
{
    value1 = Convert.ToInt32(Console.ReadLine());
    value2 = Convert.ToInt32(Console.ReadLine());   
}
catch (Exception ex) { Console.WriteLine("Введено не число"); }
Calc calc = new Calc();
int result = calc.Summer(value1, value2);
using (StreamWriter writer = new StreamWriter("C:\\Users\\Admin\\source\\repos\\MiniCalc\\log.txt", false))
{
    await writer.WriteLineAsync("Суммировалось " + value1 + " и " + value2 + " Результат " + result);
}
Console.WriteLine(result);