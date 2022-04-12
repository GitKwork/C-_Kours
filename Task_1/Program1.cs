// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Друзья идут навстречу друг другу, между ними собака бегает от одного до другого,
// сколько раз собака успеет пробежать между ними

int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

// if (distance > 10)
// { 
//     if (time = distance/(secondFriendSpeed+dogSpeed))
//     {
//         friend = 2;
//     }
//     else
//     {
//         friend = 2;
//     }
// }
// else
// {
//     Console.WriteLine($"Собака пробежит {count} раз");

// }

// time = distance/(secondFriendSpeed+dogSpeed)
// time=distance/firstFriendSpeed+dogSpeed)
// distance=distance-(firstFriendSpeed+secondFriendSpeed)*time


while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.WriteLine($"Количество раз, за которое собака пробежит, равно - {count}");
