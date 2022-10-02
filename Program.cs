// Это моя вторая программа C#
// Console.Write("numberA: ");
// int numberA = Console.ReadLine();
// Console.Write("numberB: ");
// int numberB = Console.Read();
int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.Write("Сумма равна = ");
Console.Write(result);
