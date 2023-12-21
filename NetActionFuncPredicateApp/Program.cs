Action myAction = Hello;
//myAction();

myAction = Loop;
//myAction();

Action<int> action1 = LoopNumber;
//action1(10);

Action<int, int> action2 = (a, b) =>
{
    for (int i = a; i < b; i++)
        Console.WriteLine(i);
};
//action2(5, 15);


Func<DateTime> dateCurr = () => DateTime.Now;

Console.WriteLine(dateCurr().ToLongDateString());

Func<int, int> operUnare = Square;


Predicate<int> predicate = IsPositive;
Console.WriteLine(predicate(-100));

predicate = (x) => x % 2 == 0;
Console.WriteLine(predicate(101));

int Square(int a) => a * a;

void Hello()
{
    Console.WriteLine("Hello");
}

void Loop()
{
    for(int i = 0; i < 20; i++)
        Console.WriteLine(i);
}

void LoopNumber(int number)
{
    for (int i = 0; i < number; i++)
        Console.WriteLine(i);
}

bool IsPositive(int a) => a > 0;
