// Удаление второй цифры числа

Console.WriteLine("Enter a number");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(a / 100 * 10 + a % 10);