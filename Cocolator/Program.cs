using System;

class Calculator
{
    static void Main(string[] args)
    {
        float one, two, result;
        char sign;

        Console.WriteLine("Добро пожаловать в калькулятор.");

        while (true)
        {
            Console.WriteLine("Введите первое число:");
            one = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите знак действия (-):");
            sign = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            two = Convert.ToSingle(Console.ReadLine());

            switch (sign)
            {
               
                case '-':
                    result = one - two;
                    Console.WriteLine("Разность ваших чисел равна " + result);
                    break;
                
                
                default:
                    Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                    break;
            }

            Console.WriteLine("Хотите сделать еще один расчет? (y/n)");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("До свидания!");
    }
}
