// Задача 24: 
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28 
// 4 -> 10 
// 8 -> 36

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($" Сумма чисел = {GetSumNums( num )}");

// Console.Write("Введите число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($" Сумма чисел = {GetSumNums( num1 )}"); 

// Console.Write("Введите число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($" Сумма чисел = {GetSumNums( num2 )}");
// 
// Num = number - у нас есть  метод, который обрабатывает последовательность чисел, мы можем написать некую сумму. В int num может прийти любое число(num1^ um2 и тд)
// т,е у нас есть несколько чисел и нам нужно найти три разных последовательности. Мы описываем одну функцию, которая будет это делать.
//  мы просто вызываем ее трижды(num^ num1^ num2) может быть и больше. Функцию не завязываем на каком-то конкретном числе. Поэтому в функции и стоит не 
// num, num 1 or num2 а number(sum += number). Чтобы работало для любых значений.

int GetSumNums(int number)
{
    int sum = 0;
    while(number > 0)
    {
        Console.Write($"{ number } ");
        sum += number;
        number -- ;
    }
    return sum;
}
