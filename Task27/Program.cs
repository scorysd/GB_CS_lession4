// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
while (number > 0)
{
    int temp = number %10;
    sum = temp + sum;
    number = number / 10;
} 
Console.WriteLine("Сумма цифр в числе равна: " + sum);
