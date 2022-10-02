/*Console.WriteLine("Введите скорость первого человека");
int firstFriendSpeed = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость второго человека");
int secondFriendSpeed = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость собаки");
int DogSpeed = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите дистанцию в метрах");
int Distance = Int32.Parse(Console.ReadLine());*/

int firstFriendSpeed = 2;
int secondFriendSpeed = 4;
int DogSpeed = 8;
int Distance = 2000;

int friend = 2;
int count = 0;
int time = 0;

while (Distance >= 10)
{
    if (friend == 1)
    {
        time = Distance / (firstFriendSpeed+DogSpeed);
        friend = 2;
    }
    else
    {
        time = Distance / (secondFriendSpeed+DogSpeed);
        friend = 1;
    }

    Distance = Distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
    Console.WriteLine(Distance);
    }
Console.Write("Собака пробежит count раз: ");
Console.WriteLine(count);