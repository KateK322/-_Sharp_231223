// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, 4, 3, -19, -5, 10, -23, 45 };
        int a = int.Parse(Console.ReadLine()!);
        bool b = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (a == arr[i])
            {
                b = true;
            }
        }

        if (b)
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}