// написать программу, которая на вход принемает два числа
// и проверяе, является ли первое число квадратом второго
// a=25, b=5 -> yes
// a=2, b=10 -> no
// a=8, b=-3 -> yes
// a=-3, b=9 -> no

System.Console.WriteLine("Введите  первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b * b)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}