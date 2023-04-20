//Скалярное произведение.
Console.Clear();
int[] FirstVector = { 1, 78, 63, 25, 24 };
int[] CecondVector = { 6, 83, 15, 33, 15 };
int Scalar = 0;
for (int i = 0; i < 5; i++)
{
   Scalar = Scalar + FirstVector[i] * CecondVector[i];
}
Console.WriteLine($"Скалярное произведение: {Scalar}");
