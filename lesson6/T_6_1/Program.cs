﻿/// 1. Задайте массив символов (тип char []).
//    Создайте строку из символов этого массива.

//    Конструктор строки вида string(char []) не использовать.

string concat (char [] mass)
{
    string buf = " ";
    for (int i = 0; i < mass.Length; i++) {buf = mass [i] + buf;}

    return buf;
}

char[] charArr = { 'H', 'e', 'l', 'l', 'o' };

string result = concat (charArr);
Console.WriteLine(result);