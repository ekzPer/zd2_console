using System;
class Program
{
    private static int readInt()
    {
        do
        {   
            int result;
            bool parsed = int.TryParse(Console.ReadLine(), out result);
            if (parsed) return result;
            else Console.WriteLine("Введите коректное число");
        } while(true);
    }
    static void Main()
    {
        Console.Write("Введите число A: ");
        int a = readInt();
        Console.Write("Введите число B: ");
        int b = readInt();
        if (a > b)
        {
            Console.WriteLine("B должно быть больше A");
            Console.ReadKey();
            return;
        }
        int i = a;
        Console.Write("for: ");
        for (; i <= b; i++)
        {
            if (i % 3 == 0)
                Console.Write( i + " ");
        }
        Console.WriteLine();
        i = a;
        Console.Write("while: ");
        while (i <= b)
        {
            if (i % 3 == 0)
                Console.Write( i + " ");
            i++;
        }
        Console.WriteLine();
        i = a;
        Console.Write("do while: ");
        do
        {
            if (a == b)
                break;
            if (i % 3 == 0)
                Console.Write( i + " ");
            i++;
        }
        while (i <= b);
        Console.ReadKey();
    }
}