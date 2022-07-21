// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int num1, num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Максимальное число - " + num1);
}
else
{
    Console.WriteLine("Максимальное число - " + num2);
}
*/

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int num1, num2, num3, max;
Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    max = num1;
}
else
{
    max = num2;
}

if(num3 > max)
{
    max = num3;
}

Console.WriteLine("Максимальное число - " + max);
*/

//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
int num4;
Console.Write("Введите число: ");
num4 = Convert.ToInt32(Console.ReadLine());
if(num4 % 2 == 0)
{
    Console.WriteLine("Число " + num4 + " четное.");
}
else
{
    Console.WriteLine("Число " + num4 + " нечетное!");
}
*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num5, current;
Console.Write("Введите число: ");
num5 = Convert.ToInt32(Console.ReadLine());
current = 2;
while(current <= num5)
{
Console.Write(current + ", ");
current = current + 2;
}
