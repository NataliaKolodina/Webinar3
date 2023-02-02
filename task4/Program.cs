// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.


// 5 -> 1, 4, 9, 16, 25.
Console.Clear();
Console.WriteLine("Введите число ");
double N = double.Parse(Console.ReadLine()!);
double count = 1;
double count1 = -1;

if (N > 0)
{
    while (count <= N)
    {
    Console.Write(Math.Pow(count, 2) + ",");
    count++;
    }
}
else
{
    while (count1 > N)
    {
    Console.Write(Math.Pow(count1, 2) + ",");
    count1--;
    }
}