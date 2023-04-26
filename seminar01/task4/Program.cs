// напишите программу, которая на вход принимает одно число N, 
//а на выход показывает все целые числав промежутке от -N до N

// System.Console.WriteLine("Введите целое число; ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = -N;
// while(i <= N)
// {
//     System.Console.WriteLine(i + " "); // + и кавычки в терминале показывают пробел
//     i++;
// }


// параметры цикла for(переменная счетчик; условия цикла; изменения переменной счетчика;)
// всепараметры пишуться внутри цикла for  в круглых скобках 
System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = -N; i <= N; i++)
{
    System.Console.Write(i + " ");
}
