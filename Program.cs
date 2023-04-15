//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

int FiveDigitNumber()
{
    bool isSelector = true;
    int num = 0;
    while (isSelector)
    {
        Console.Write("Ввудите пятизначное число = ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 10000 && num < 100000)
        {
            Console.WriteLine($"Введенное число = {num}");
            isSelector = false;
            break;
        }
        else
        {
            Console.WriteLine($"Введенное число {num} не является пятизначным, попробуйте снова");
        }
    }
    return num;
}


int number = FiveDigitNumber();

int numFirst, numLast;
int divFirst = 10000;

while (number > 0)
{
    if (number < 10)
    {
        Console.WriteLine("Данное число полиндром");
        break;
    }
    else
    {
        numFirst = number / divFirst;
        numLast = number % 10;
        if (numFirst == numLast)
        {
            number = number % divFirst / 10;
            divFirst = divFirst / 100;
        }else{
            Console.WriteLine("Данное число не полиндром");
            break;
        }
    }
}

