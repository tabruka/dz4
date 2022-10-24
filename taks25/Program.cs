// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {numA} в степени {numB} = {DegreeNumber(numA, numB)}");


int DegreeNumber(int numA, int numB)
{
    if(numB == 0)
    {
        return 1;
    }
    if(numA == 0)
    {
        return 0;
    }
    int result = 1;
    for (int i = 1; i <= numA; i++)
    {
        result = result * numB;
    }
    return result;
}