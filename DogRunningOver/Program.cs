//Перебегания собаки.
Console.Clear();
Console.WriteLine("Сколько раз собака пробежала туда и обратно? ");
double i = 0;
double distance = 10000;
double speedA = 2;
double speedB = 1;
double speedC = 5;
double time = 0;
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
         time = distance / (speedC + speedB);
         course = e;
      }
   distance = distance - (speedA + speedB) * time;
   i++;
}
Console.WriteLine($"Собака пробежала {i} раз");