using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Узнать оценку теста");
            Console.Write("Введите свое кол-во баллов: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 100 && n >= 0)
            {
                if (n >= 90)
                    Console.WriteLine("Отлично");
                if (n >= 70 && n < 90)
                    Console.WriteLine("Хорошо");
                if (n >= 50 && n < 70)
                    Console.WriteLine("Удовлетворительно");
                if (n < 50)
                     Console.WriteLine("Неудовлетворительно");
            }
            else Console.WriteLine("Вы ошиблись!");

        }
    }
}
