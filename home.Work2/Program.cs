//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Clear();

Console.WriteLine("Hello leather bas**** ");

Console.Write("Enter the figure of the day of the week : ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(Weekend");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("And what did you write? There are only 7 of them!");
  }
  else Console.WriteLine("Not weekend! ");
}

CheckingTheDayOfTheWeek(dayNumber);
*/


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Clear();

Console.WriteLine("Hello leather bas**** ");

Console.Write("Enter number: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());

string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2){

  Console.WriteLine("Three num -> " + anyNumberText[2]);

}

else {

  Console.WriteLine(" There is no third digit ");

}
*/
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();

Console.WriteLine("Hello leather bas**** ");

Console.Write("Enter a three-digit number ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine($"the second digit of this number {stringNumber[1]}");
