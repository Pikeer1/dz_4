//Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int step = number1;

for (int i = 1; i < number2; i++)
{
    step *= number1;
}

Console.WriteLine($"Первое число в степени второго = {step}");