// Принимать на вход 2 числа и выводить является ли второе число кратно первому. Если второе число не кратно выводить остаток

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a % b == 0) {Console.WriteLine("true");}
else {Console.WriteLine("false" + a % b);}
