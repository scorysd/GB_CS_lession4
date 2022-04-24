// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
Console.Clear();
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую необходимо ввести число:");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine($"{a} в степени {b} = {result}");