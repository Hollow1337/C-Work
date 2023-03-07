/*
Console.WriteLine("Good Evening" );
// int integer = 34;
// double doublenum = 2.11111;

// string world = "Hello";
// char symbol = 'f';

// bool check = true;

//int num1 = 5;
//int num2 = 10;

//Console.WriteLine("My number is " + num + " and " + num1 +  " and is good ");
//Console.WriteLine($"My number are  {num}  and  {num1}  and is good");
//Console.Write("input: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите число 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}

Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input a positive number ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while (current <= number)
{
    Console.Write(current + " ");
    current++;
} 

32141 / 10 = 3214
32141 / 100 = 321
32141 / 1000 = 32
32141 / 100000 = 3

32143 % 10 = 3
32143 % 100 = 43
32143 % 1000 = 143
32143 % 10000 = 2143

32141 / 100 % 100 
234522 / 10 % 100 
31235 / 100 % 100 
*/