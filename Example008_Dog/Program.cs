int count = 0;
int distanse = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int friend = 2;
int time = 0;

while (distanse > 10)
{
    if (friend == 1)
    {
        time = distanse / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        time = distanse / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    distanse = distanse - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}
Console.WriteLine(String.Format("Собака бежит {0} раз", count));