// Это моя вторая программа C#
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

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");

Console.WriteLine(max);
