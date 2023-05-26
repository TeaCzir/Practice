// Сумма элементов массива между максимальным и минимальным элементом.
Console.Clear();
int[] a = { 2, 9, 5, 7, 3, 1, 8 };
// int[] a = { 12, 29, 5, 7, 13, 3, 8 };
int size = a.Length;
int i = 0;
int max = a[0];
int min = a[0];
int imax = 0;
int imin = 0;
int sum = 0;
while (i < size)
{
   if (a[i] < min)
   {
      min = a[i];
      imin = i;
   }
   if (a[i] > max)
   {
      max = a[i];
      imax = i;
   }
   i++;
}
sum = sum + a[2] + a[3] + a[4];
Console.WriteLine($"Максимальный равен: {max} его индекс: {imax} ");
Console.WriteLine($"Минимальный равен: {min} его индекс: {imin} ");
Console.WriteLine($"Сумма от максимального до минимального {sum} ");
int s = 0;
s = s + a[1] + a[2] + a[3] + a[4] + a[5];
Console.WriteLine($"Сумма включительно: {s} ");