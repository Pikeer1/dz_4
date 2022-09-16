// Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while( number > 0)
{
    int num = number % 10;
    number /= 10;
    summa += num;
}

Console.WriteLine($"Сумма цифр в числе = {summa}");