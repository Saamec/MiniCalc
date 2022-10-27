
using MiniCalc;
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
Console.WriteLine(result);