//Второе максимальное число.
Console.Clear();
int[] number = { 1, 8, 33, 52, 6, 8, 25, 50 };
int size = 8;
int current_index = 0;
int max_number_index = 0;
int max = number[0];
while (current_index < size)
{
   if (number[current_index] > max)
   {
      max = number[current_index];
      max_number_index = current_index;
   }
   current_index++;
}
Console.WriteLine($"Максимальное число равно: {max}");
Console.WriteLine($"Индекс максимального числа равен: {max_number_index}");
int cur_index = 0;
int second_max = number[0];
if (max_number_index == 0)
{
   second_max = number[1];
}
while (cur_index < size)
{
   if (cur_index != max_number_index)
   {
      if (number[cur_index] > second_max)
      {
         second_max = number[cur_index];
      }
   }
   cur_index++;
}
Console.WriteLine($"Второе максимальное число равно: {second_max}");
// Console.WriteLine($"Максимальное число равно: {max}");
// Console.WriteLine($"Индекс максимального числа равен: {max_number_index}");
