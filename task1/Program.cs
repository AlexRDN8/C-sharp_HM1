// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Введите 1 число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("наибольшее число ");
    Console.WriteLine(number1);
    Console.Write("наименьшее число ");
    Console.WriteLine(number2); 
}
if (number1 < number2)
{
    Console.Write("наибольшее число ");
    Console.WriteLine(number2);
    Console.Write("наименьшее число ");
    Console.WriteLine(number1); 
}
if (number1 == number2)
{
    Console.Write("Числа равны");
}
