// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num > 100 && num < 1000)
{
    num = num % 100 / 10;
    Console.WriteLine(num);
}
else Console.WriteLine("не верно");