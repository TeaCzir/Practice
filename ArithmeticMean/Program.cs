//Среднее арефметическое.
Console.Clear();
int[] num = {205,195,739,512,995,888,1035,340,739,512,995,888,1035,340};
int size = 14;
int sum = 0;
int ArithmeticMean = 0;
for (int i = 0; i < size; i++)
{
   sum = sum + num[i];
}
ArithmeticMean = sum/size;
Console.WriteLine($"Среднее арефметическое массива равно: {ArithmeticMean}");