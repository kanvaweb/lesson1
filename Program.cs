﻿// Это моя вторая программа C#
// Console.Write("numberA: ");
// int numberA = Console.ReadLine();
// Console.Write("numberB: ");
// int numberB = Console.Read();
// int numberA = new Random().Next(1, 10);
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.Write("Сумма равна = ");
// Console.Write(result);

// Console.Write("Введите имя пользователя: ");
// string username = Console.ReadLine();

// if (username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура! Это же Маша");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.Write(username);
// }

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// Console.Write("max = ");
// Console.WriteLine(max);

Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 60, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);

    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}