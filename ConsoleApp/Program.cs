using System;

class Program
{
    static void Main()
    {
        // Введення десяткового числа
        Console.Write("Введiть десяткове число: ");
        string? input = Console.ReadLine();

        if (input != null)
        {
            int decimalNumber = int.Parse(input);

            // Вибір системи числення
            Console.WriteLine("Виберiть систему числення (2 - двiйкова, 8 - вiсiмкова, 16 - шiстнадцяткова): ");
            string? baseInput = Console.ReadLine();

            if (baseInput != null)
            {
                int baseSystem = int.Parse(baseInput);
                string result = "";

                // Переведення в обрану систему числення
                switch (baseSystem)
                {
                    case 2:
                        result = Convert.ToString(decimalNumber, 2);
                        break;
                    case 8:
                        result = Convert.ToString(decimalNumber, 8);
                        break;
                    case 16:
                        result = Convert.ToString(decimalNumber, 16).ToUpper();
                        break;
                    default:
                        Console.WriteLine("Невiрно обрана система числення.");
                        return;
                }

                // Виведення результату
                Console.WriteLine($"Число в системi числення з основою {baseSystem}: {result}");
            }
            else
            {
                Console.WriteLine("Введено некоректне значення.");
            }
        }
        else
        {
            Console.WriteLine("Введено некоректне значення.");
        }
    }
}
