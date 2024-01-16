// 2. Задайте массив из 10 элементов, заполненный числами из
//    промежутка [-10, 10]. Замените отрицательные элементы на
//    положительные, а положительные на отрицательные.

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = {1, 4, -5, 6, -10, 61, -91, 45};
       
        for (int i = 0; i < arr.Length; i++ )
        {
            arr [i] = arr [i] * -1;
            Console.Write ($"{arr[i]} ");       
         }
}
}