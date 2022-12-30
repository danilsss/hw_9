/*Задача: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/

Console.WriteLine("Введите число больше 1:");
int number = int.Parse(Console.ReadLine());

void NumberCounter (int number)
{
if (number < 0) Console.Write($"{number} не натуральное число");
if (number == 0) return;
Console.Write("{0,4}", number);
NumberCounter (number - 1);
}

NumberCounter(number);


/*Задача: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
*/

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);
