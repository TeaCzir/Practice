//Перебегания собаки.
Console.Clear();
Console.WriteLine("Сколько раз собака пробежала туда и обратно? ");
int i = 0;
int distance = 10000;
int speedA = 2;
int speedB = 1;
int speedC = 5;
int time = 0;
bool e = true;
bool x = false;
bool course = e||x;
while (distance > 10)
{
   if (e)
     {
      time = distance / (speedC + speedA);
      course = x;
     }
     if (x)
      {
         time = distance / (speedC - speedB);
         course = e;
      }
   distance = distance - (speedA - speedB) * time;
   i++;
}
Console.WriteLine($"Собака пробежала туда и обратно {i} раз.");