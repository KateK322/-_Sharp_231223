// 1. Задайте одномерный массив, заполненный случайными
//    числами. Определите количество простых чисел в этом
//    массиве.

static void Main ()
{
    // Создаем рандом для генерации случайных чисел
    Random random = new Random ();
    // Создаем массив из случайных чисел
    int[] numbers = new int [10];
    for (int = 0, int < numbers.Length; i++)
    {
        numbers[1] = random.Next(1,100);
    }
    int count = 0;
    foreach (var number is numbers);
    {
        if (isPrime(number))
        {
            count++
        }
        Console.WriteLine ("Количество числел в массиве: " + count);
    }
}
static bool isPrime (int number)






sing System;

class Program
{
    static void Main()
    {
        //создаем объект Random для генерации случайных чисел
        Random random = new Random();
        //создаем массив из 10 случайных чисел
        int[] numbers = new int[10];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100); //генерация случайного числа от 1 до 100
        }
        //определение кол-во простых чисел в массиве
        int count = 0;
        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                count++;
            }
        }
        //вывод результата
        Console.WriteLine("Количество простых чисел в массиве: "+ count);
    }
    //метод для определения является ли число простым
    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}