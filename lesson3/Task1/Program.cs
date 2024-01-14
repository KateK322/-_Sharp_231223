// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

int[] arr = { 1, 3, 5, 10, 23 };
int a = int.Parse(Console.ReadLine()!);
bool b = false;

for (int i = 0; i < arr.length; i++)
{
    if (a == arr[i])
        b = true;
}
if (b)
    Console.Write("Yes");
else
    Console.Write("No");
