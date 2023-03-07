/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");

int MaxNumber = 0;
int MinNumber = 0;

Console.Write("Number1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Number3: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if(Number1 > Number2)
{
    MaxNumber = Number1;
    MinNumber = Number2;
}
else
{
    MaxNumber = Number2;
    MinNumber = Number1;
}
Console.WriteLine("Max = " + MaxNumber + " и " + "Min = " + MinNumber);


/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 
*/

Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них больше");

int MaxNumber = 0;

Console.Write("Input Number1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Number2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Number3: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

if(Number1 > MaxNumber)

    MaxNumber = Number1;

if(Number2 > MaxNumber)
    MaxNumber = Number2;
    
if(Number3 > MaxNumber)
        
    MaxNumber = Number3;
        

Console.WriteLine("Max = " + MaxNumber);



/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
*/

Console.WriteLine("Введи число и мы узнаем четное ли оно");

Console.Write("Input Number1: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введи число и мы увидим все четные до него");

Console.Write("Input num1: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}