//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n
Console.Clear();

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Введите натуральное число m");
int n = EnterNumber("Введите натуральное число n");

int AkkermanFunc (int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (a == 0 && b > 0)
    {
        return AkkermanFunc (a - 1, 1);
    }
    else
    {
        return (AkkermanFunc (a - 1, AkkermanFunc (a, b - 1)));
    }
}

Console.WriteLine(AkkermanFunc(m, n));
