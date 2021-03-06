using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // сразу договоримся, что если зарандомился 0 - то это камень, если зарандомилась 1 - то это ножницы, если зарандомилась 2 - то это бумага
            Random random = new Random();
            int comp = random.Next(3); //метод нам вернет случайное число от 0 до 2
            Console.WriteLine("Сколько попыток хочешь сыграть с компьютером?");
            string kolvo = Console.ReadLine(); // ввожу кол-во попыток
            bool num = Int32.TryParse(kolvo, out int result); // проверка на числовое значени. (kolvo = число ? пропускает дальше : консоль закрывается)
            if (num == true)
            {
                if (result == 0) // проверка на особо умных
                {
                    Environment.Exit(0); // консоль останавливает свою работу
                }
                Console.WriteLine("Выберите элемент игры: камень, ножницы или бумага");
                int i = 1; // счетчик для цикла, чтобы было с чем сравнивать кол-во выбранных игр, ниже будет понятнее
                do // начало цикла  раз
                {
                    string vibor = Console.ReadLine(); // тут ввожу камень ножницы или бумагу
                    switch (vibor)
                    {
                        case "камень":
                            if (comp == 0)
                            {
                                Console.WriteLine("Ничья. Компьютер показал камень");
                            }
                            else if (comp == 1)
                            {
                                Console.WriteLine("Поздравляю! Ты выиграл, компьютер показал ножницы");
                            }
                            else if (comp == 2)
                            {
                                Console.WriteLine("Жаль, но ты проиграл. Компьютер показал бумагу");
                            }
                            break;
                        case "ножницы":
                            if (comp == 0)
                            {
                                Console.WriteLine("Жаль, но ты проиграл. Компьютер показал камень");
                            }
                            else if (comp == 1)
                            {
                                Console.WriteLine("Ничья. Компьютер показал ножницы");
                            }
                            else if (comp == 2)
                            {
                                Console.WriteLine("Поздравляю! Ты выиграл, компьютер показал бумагу");
                            }
                            break;
                        case "бумага":
                            if (comp == 0)
                            {
                                Console.WriteLine("Поздравляю! Ты выиграл, компьютер показал камень");
                            }
                            else if (comp == 1)
                            {
                                Console.WriteLine("Жаль, но ты проиграл. Компьютер показал ножницы");
                            }
                            else if (comp == 2)
                            {
                                Console.WriteLine("Ничья. Компьютер показал ножницы");
                            }
                            break;
                        default:
                            Console.WriteLine("Пытаешься сжульничать?");
                            break;
                    }
                    i++;
                    comp = random.Next(0, 3);
                    if (i - 1 == Convert.ToInt32(kolvo))
                    {
                        Console.WriteLine("Игра окончена");
                    }
                    else Console.WriteLine("Вводи еще раз"); // после попытки дается еще одна
                } while (i <= Convert.ToInt32(kolvo)); // для этого и нужен счетчик
                Console.WriteLine("Спасибо за игру");
                Console.ReadKey();
            }
            else
            {
                Environment.Exit(0); // если ввели кол-во игр !число
            }
        }
    }
}
