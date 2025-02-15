using System;

class First
{
    public class Logic {
        public static int[] Compare(int a, int b, int c) {
            int[] nums = new int[3];
            if (a >= b && a >= c)
                nums[0] = a;
            else if (b >= a && b >= c)
                nums[0] = b;
            else
                nums[0] = c;

            if (a <= b && a <= c)
                nums[1] = a;
            else if (b <= a && b <= c)
                nums[1] = b;
            else
                nums[1] = c;

            if (a != nums[0] && a != nums[1])
                nums[2] = a;
            else if (b != nums[0] && b != nums[1])
                nums[2] = b;
            else nums[2] = c;

            return nums;
        }
    }
    static void Main()
    {
        // НАЧАЛО взаимодействия с пользователем
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        // КОНЕЦ взаимодействия с пользователем

        // НАЧАЛО логики
        int[] nums = Logic.Compare(a, b, c);
        // КОНЕЦ логики

        // НАЧАЛО взаимодействия с пользователем
        Console.WriteLine($"Самое большое число: {nums[0]}");
        Console.WriteLine($"Самое маленькое число: {nums[1]}");
        Console.WriteLine($"Самое среднее число: {nums[2]}");
        // КОНЕЦ взаимодействия с пользователем
    }
}

