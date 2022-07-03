// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Zadacha17(number);

void Zadacha17(int number)
{
    Console.WriteLine();
    int count = 1;
    while (number >= count)
    {
        Console.WriteLine($"{Math.Pow((count),3)}");
        count++;
    }
}