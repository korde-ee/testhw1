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
/*
int num5, current;
Console.Write("Введите число: ");
num5 = Convert.ToInt32(Console.ReadLine());
current = 2;
while(current <= num5)
{
Console.Write(current + ", ");
current = current + 2;
}
*/
//-------------------------------------------------------------------------------------
// Задания второго практического урока

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
//вариант 1
int num6, middle;
Console.Write("Введите трехзначное число: ");
num6 = Convert.ToInt32(Console.ReadLine());
middle = num6 / 10 % 10;
Console.WriteLine("Вторая цифра числа " + num6 + " - " + middle);

//вариант2, с использованием метода.
int SecondDigit(int num)
{
    int des = num / 10; //Получаем первое и второе числа от трехзначного числа.
    int ed = des % 10; //Получаем остаток от деления на 10, второе число.
    return ed;
}

int number = new Random().Next(100, 999);
int middle = SecondDigit(number);
//Console.WriteLine("Вторая цифра числа " + number + " - " + middle);
Console.WriteLine($"Вторая цифра числа {number} - {middle});
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

int TherdDigit(int num)
{
    int therd = num % 10;
    return therd;
}

int DoNumberTreeDigit(int num)
{
    if(num > 99 && num <= 999)
    {
        int chislo = TherdDigit(num);
        return chislo;
    }
    else
    {
        while(num > 999)
        {
            num /= 10;
        }
        int chislo = TherdDigit(num);
        return chislo;
    }
}
int number = new Random().Next(0, 999999);

if(number < 99)
{
    Console.WriteLine($"В числе{number} - третьей цифры нет");
}
else
{
    int therdnumber = DoNumberTreeDigit(number);
    Console.WriteLine($"В числе {number}, третья цифра - {therdnumber}");
}

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
bool CheckWeekDay(int num)
{
    if(num == 6 || num == 7) return true;
    else return false;
}
Console.Write("Введите число от 1 до 7: ");
int num1 = Convert.ToInt32(Console.ReadLine());
bool ifweekend = CheckWeekDay(num1);
Console.WriteLine($"День {num1} является выходным - {ifweekend}");
