﻿// написать программу, которая будет выдавать название 
// дня недели по заданнному номеру
// 3 -> среда
// 5 -> пятница

System.Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (number == 3)
{
    System.Console.WriteLine("Среда");
}
else if (number == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (number == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (number == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (number == 7)
{
    System.Console.WriteLine("Воскресенье");
}



