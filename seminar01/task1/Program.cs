// написать программу, которая на вход принимает число и выдает его квадрат
// (число умноженное само на себя)
//  4->16
// -3->9
//  -7->49

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"квадратное число: {sqr}");
