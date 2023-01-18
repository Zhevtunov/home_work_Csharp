// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введи число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = 0;
Console.Write("Четные числа: ");
while (number1 > number2 + 1)
{
  number2 = number2 + 2;
  
  Console.Write(number2);
  Console.Write(",");
}