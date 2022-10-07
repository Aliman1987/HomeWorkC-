//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3//

/*
Console.WriteLine("Input a first number ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
Console.WriteLine("Largest number is: " + n1 + " smallest number is: " + n2 );
}
else
{
Console.WriteLine("Largest number is: " + n2 + " smallest number is: " + n1 );
}
*/

/*//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22
Console.Write("Input a first number ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number ");
int n3 = Convert.ToInt32(Console.ReadLine());

int nmax = n1;

if(n2 > nmax) nmax = n2;
if(n3 > nmax) nmax = n3;

Console.WriteLine($"Maximum number of numbers {n1}, {n2}, {n3} is {nmax} ");
*/
/*
//  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет
Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine($" {n} -> Yes ");
}
else
{
    Console.WriteLine($" {n} -> No ");
}
*/
/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
int current = -n;
if(n < 0)
{
    current = n;
    n = -n;
}
while(count < n)
{
    Console.Write(count + ", ");
    count = count +2;
}
*/