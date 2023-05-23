Console.Clear();
Console.Write("Это наш массив: ");
int[] arr = { 2, 8, 3, 5, 7, 9, 4 };
for (int i = 0; i < 7; i++)
{
   Console.Write($"{arr[i]}, ");
}
Console.WriteLine();
Console.Write("А это массив в обратном порядке: ");
for (int i = 7 - 1; i >= 0; i--)
{
   Console.Write($"{arr[i]}, ");
}