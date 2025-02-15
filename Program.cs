using System;

class First
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int ladge;
        if (a >= b && a >= c)
            ladge = a;
        else if (b >= a && b >= c)
            ladge = b;
        else
            ladge = c;

        int small;
        if (a <= b && a <= c)
            small = a;
        else if (b <= a && b <= c)
            small = b;
        else
            small = c;

        int sred;
        if (a != ladge && a != small)
            sred = a;
        else if (b != ladge && b != small)
            sred = b;
        else sred = c;

        Console.WriteLine($"Самое большое число: {ladge}");
        Console.WriteLine($"Самое маленькое число: {small}");
        Console.WriteLine($"Самое среднее число: {sred}");
    }
}
