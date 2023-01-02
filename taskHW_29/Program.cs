// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]
int[] CreateRandArray()
{
    int[] array = new int[8];
    for(int i = 0; i < 8; i ++ )
    {
        array[i]= new Random().Next(0 , 2);
    }
    return array;
}
void PrintRandArry(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < 7; i ++)
    Console.Write(arr[i] + ",");
    Console.Write(arr[7] + "]");
}
PrintRandArry(CreateRandArray());
