//Sum of even - сумма четных чисел.
Console.Clear();
Console.Write("Сумма четных чисел от 1 до 15 равна: ");

int sum = 0;
for (int num = 2; num < 15; num+=2)
{
   sum = sum + num;
}
Console.Write($"{sum}");

