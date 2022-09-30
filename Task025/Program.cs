/*  Задача 25: Напишите цикл, который принимает на вход два числа 
    (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16                                                  */

int exponentiationUserNumbers(int firstUserNumber, int secondUserNumber)
{
    int result = firstUserNumber;
    for (int i = 1; i < secondUserNumber; i++)
    {
        result = result * firstUserNumber;
    }
    return result;
}

Console.WriteLine("Для возведения в степень, введите два целых положительных числа.");
Console.Write("Введите первое число: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

int result = exponentiationUserNumbers(firstUserNumber, secondUserNumber);
Console.WriteLine($"Число {firstUserNumber} в степени {secondUserNumber} = {result}");