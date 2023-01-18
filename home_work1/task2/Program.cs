//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Ввведите первое число ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int number3 = int.Parse(Console.ReadLine());

int number_max = number1;

if (number2 >= number_max)
{
  number_max = number2;
}
if (number3 >= number_max)
{
  number_max = number3;
}
Console.Write("Максимальное число: ");
Console.WriteLine(number_max);