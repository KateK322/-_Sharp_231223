// Принимает на вход трёхзначное число, воводит вторую цифру в степень равную третей цифре

int a = int.Parse(Console.ReadLine()!);
int secomndNumber = a / 10 % 10;
int thirdNumber = a % 10;
Console.WriteLine(Math.Pow(secomndNumber,thirdNumber));

