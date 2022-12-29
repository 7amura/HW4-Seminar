// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (35) 
// 2, 4 -> 16

Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number b: ");
int b = int.Parse(Console.ReadLine());

int Pow(int a, int b)
{
    int num = 1;
    int result = 1;
    for(num = 1; num <= b; num++)
    {
        result = result * a;
    }
    return result;
}
int result = Pow(a, b);

Console.WriteLine($"Числао {a}, возведенное в степень {b} = {result}");
