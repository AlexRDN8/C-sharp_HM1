// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите 1 число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3 число");
int number3 = int.Parse(Console.ReadLine());

if (number1 >= number2 & number1 >= number3)
{
    Console.WriteLine("максимальное число ");
    Console.Write(number1);
}
else if (number2 >= number1 & number2>= number3)
{
    Console.WriteLine("максимальное число ");
    Console.Write(number2);
}
else
{
    Console.WriteLine("максимальное число ");
    Console.Write(number3);
}