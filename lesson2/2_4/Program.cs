// Программа выводит третью с конца цифру заданного числа или сообщает что третей цифры нет

int a = int.Parse(Console.ReadLine()!);

if (a < 100) {Console.WriteLine ("False");}
else {Console.WriteLine ("True" + a / 100 % 10);}
