// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100) Console.WriteLine("нет третьей цифры");
if (num > 99 && num < 1000)
{
    num = num % 10;
    Console.WriteLine(num);
}
if (num > 999 && num < 10000)
{
    num = num % 100 / 10;
    Console.WriteLine(num);
}
if (num > 9999 && num < 100000)
{
    num = num % 1000 / 100;
    Console.WriteLine(num);
}