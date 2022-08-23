//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int cycle = 2;

Console.Clear();

while(cycle <= number)
{
    Console.WriteLine(cycle);
    cycle+=2;
}
