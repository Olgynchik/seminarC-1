// напишите программу, которая на вход принимает одно число N, 
//а на выход показывает все целые числав промижутке от -N до N

System.Console.WriteLine("Введите целое число; ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while(i <= N)
{
    System.Console.WriteLine(i + " "); // + и кавычки в терминале показывают пробел
    i++;

}
