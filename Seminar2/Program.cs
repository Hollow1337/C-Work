/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

    int result = hundreds * 10 + units;
    return result;

}


int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxNumber(int num);
{
    int decades = num / 10;
    int units = MaxNum % 10;
    int max = decades;

    if (units > decades)

    {
        max = units;
    }
    return max;

}

int number = new Random().Next(10, 100);

int maxNum = MaxNumber(number);

Console.WriteLine($"Максимальная цифра {number} - {maxNum}. ");

*/

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool Multiplisity(int userNum, int a, int b);
{
    if (userNum % a == 0 && userNum % b == 0)
        return true;
    else
         return false;
}


int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число a");

int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b");

int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число проверки");

bool resMult = Multiplisity(number, a, b);

Console.WriteLine($"Проверка на кратность - {resMult}");
*/