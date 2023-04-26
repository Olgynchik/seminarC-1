// напишите программу,  которая принимает на вход трехзначное число
// и на выход показывает последнюю цифру этого числа 
System.Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());

if(A > 99 && A < 1000)
{
    System.Console.WriteLine(A % 10);
}
System.Console.WriteLine("Error");