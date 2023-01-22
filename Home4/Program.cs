// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int currentN = 1;
while(currentN<= N)
{
    if (currentN %2 ==1)
    currentN++;
    else
    {
        System.Console.Write(currentN + " ");
        currentN++;
    }
}