// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите цифру 8");
int аrray = int.Parse(Console.ReadLine());
if(аrray == 8)
{
Console.Write("Массив из 8-ми элементов: ");
}
else
{
    Console.WriteLine("Введена не верная цифра, необходимо было ввести цифру 8. Попробуйте еще раз");
}
RandomArray(аrray);
int[] RandomArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n && n == 8; i++)
    {
        array[i] = new Random().Next(0,9);
        Console.Write($"{array[i]},");
    }
    return array;
}