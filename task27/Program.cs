// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр введенного числа {number} = {SumDigits(number)}");

int SumDigits(int number)
{
    int result = 0;
    for (int i = 0; i <= result; i++)
    {
        int findlastdigit = number % 10;
        number = number / 10;
        result = result + findlastdigit;
    }
    return result;
}