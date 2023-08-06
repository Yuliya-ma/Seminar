//Seminar 1
//Theory

/*
int intNumber = 25;
double doubleNumber = 12.12;
string text = "some text";
 bool logicVar = true;


Console.Write("Input a number");
int num = Convert.ToInt32(Console.ReadLine() );

Console.WriteLine("Your number is " + num);
*/

//Task 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num 1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if (num1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

//Task 2. Напишите программу, которая на вход принимает положительное число (N),
//а на выходе показывает все целые числа в промежутке -N до N.

/* 
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// Домашнее задание к Семинару 1

//Task 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2)
{
    Console.WriteLine("max = " + num1);
}

else
{
    Console.WriteLine("max = " + num2);
}
*/

//Task 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine("max = " + num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine("max = " + num2);
}
else 
{
    Console.WriteLine("max = " + num3);
}
*/

//Task 6.Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

/*
Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int ost = num % 2;

if (ost == 0)
{
    Console.WriteLine("Yes");
}
else

{
    Console.WriteLine("No");
}
*/

//Task 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a numder ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
    if (current % 2 == 0)
    {
        Console.Write(current + ", ");
    }
    current++;
}
*/

