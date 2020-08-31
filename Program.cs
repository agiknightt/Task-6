using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiac;
            string job;

            Console.Write("Введите ваше имя : ");            
            name = Console.ReadLine();

            Console.Write("Сколько вам лет? : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой ваш знак зодиака? : ");
            zodiac = Console.ReadLine();

            Console.Write("Кем вы работаете? : ");
            job = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} лет, ваш знак зодиака {zodiac}, вы работаете {job}.");
            Console.ReadKey();
        }
    }
}
