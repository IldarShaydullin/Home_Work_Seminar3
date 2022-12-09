// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.

/*
int SecondNum(int arg)
{
    arg = arg / 10 %10;
    return arg;
}
Console.Write("Введите любое трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondNum(number);
Console.WriteLine(result);
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
// третьей цифры нет.

/*
int Method(int num)
{
    if(num < 100)
        return num = -1;
    else
        {
        while(num > 1000)
        num = num / 10;
        int ru = num % 10;
        return ru;
        }
}

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Method(number);

Console.WriteLine(result);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

/*
bool Hol(int numday)
{
if(numday == 6 || numday == 7)
    {
        bool result = true;
        return result;
    } 
else
    {
        bool result = false;
        return result;
    }
}

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
bool day = Hol(number);
Console.WriteLine(day);
*/
