// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Введите количество элментов массива: ");
int[] mass = new int[Convert.ToInt32(Console.ReadLine())];
Console.Clear();
void PrintMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillMass()
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next();
    }
}
FillMass();
PrintMass(mass);