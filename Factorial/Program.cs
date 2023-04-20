//Факториал числа.
Console.Clear();
Console.Write("Введите число: ");
double N = double.Parse(Console.ReadLine());
double a = 1;
double b = 1;
while (b <= N)
{
   a = a * b;
   b++;
}
Console.WriteLine($"Факториал числа: {N} равен числу: {a}");
