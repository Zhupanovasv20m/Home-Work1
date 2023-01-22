//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа через Enter");
int numberA= Convert.ToInt32(Console.ReadLine());
int numberB= Convert.ToInt32(Console.ReadLine());

   int max = Convert.ToInt32(Math.Max (numberA, numberB));
   int min = Convert.ToInt32(Math.Min (numberA, numberB));
System.Console.WriteLine("max=" + max);
System.Console.WriteLine("min=" + min);