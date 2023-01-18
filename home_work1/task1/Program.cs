//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write ("введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(numberA);
    Console.Write("Наменьшее число: ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(numberB);
    Console.Write("Наменьшее число: ");
    Console.WriteLine(numberA);
}