// Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.

int [] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
{
    numbers [i] = new Random().Next(0,20);
    Console.Write(Print(i) + " ");
}

int Print (int num)
{
    return numbers[num];
}