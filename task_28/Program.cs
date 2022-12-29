// Задача 28: 
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
 
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($" Произведение чисел: = {GetComposNums( n )}");

int GetComposNums(int number)
{
    int compos = 1;
    while(number > 0)
    {
        Console.Write($"{number} ");
        compos *= number;
        number --;
    }
    return compos;
}
