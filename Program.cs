using System;
/*Грамматика Доктора Кто.Какие то фразы вспомнил,какие то придумал.
 * Фраза=%Утверждение|%Вопрос|%Клич
 * Утверждение=Мы на планете %Планета %Год год|%Вещь это круто|Не моргай!
 * Планета=Земля|Галлифрей|Калуфракс|Мессалина|Трензалор
 * Год=%Цифра|%Цифра%Год
 * Цифра=0|1|2|3||4|5|6|7|8|9
 * Клич=Джеронимо!|Аллонзо!|Фантастика!
 * Вопрос=%Спутник ,а мы где?|Зачем ты здесь?
 * Спутник=Роза|Джек|Эми
 * Вещь=Бабочка|Феска
*/
namespace example_lexer
{
    class Lexer
    {
        static Random myRandom = new Random();
        public static void sentense()
        {
            var rand = myRandom.Next(0,3);
            switch (rand)
            {
                case 0:
                    statement(); break;
                case 1:
                    question();break;
                case 2:
                    watchword();break;
            }
        }

        public static void statement()
        {
            var rand = myRandom.Next(0,3);
            switch (rand)
            {
                case 0:
                    Console.Write("Мы на планете ");
                    planet();
                    Console.Write(" ");
                    year();
                    Console.Write(" год");
                    break;
                case 1:
                    item();
                    Console.Write(" это круто");
                    break;
                case 2:
                    Console.Write("Не моргай!");
                    break;
            }
        }
        public static void question()
        {
            var rand = myRandom.Next(0, 2);
            switch (rand)
            {
                case 0:
                    ally();
                    Console.Write(" ,а мы где?");
                    break;
                case 1:
                    Console.Write("Зачем ты здесь?");
                    break;
            }
        }
        public static void watchword()
        {
            var rand = myRandom.Next(0, 3);
            switch (rand)
            {
                case 0:
                    Console.Write("Джеронимо!"); break;
                case 1:
                    Console.Write("Аллонзо!");break;
                case 2:
                    Console.Write("Фантастика!");break;
            }
        }
        public static void planet()
        {
            var rand = myRandom.Next(0, 5);
            switch (rand)
            {
                case 0:
                    Console.Write("Земля"); break;
                case 1:
                    Console.Write("Галлифрей");break;
                case 2:
                    Console.Write("Калуфракс");break;
                case 3:
                    Console.Write("Мессалина");break;
                case 4:
                    Console.Write("Трензалор");break;
            }
        }
        public static void year()
        {
            var rand = myRandom.Next(0, 2);
            switch (rand)
            {
                case 0:
                    digit(); break;
                case 1:
                    digit();
                    year();
                    break;
            }
        }
        public static void digit()
        {
            var rand = myRandom.Next(0,9);
            switch (rand)
            {
                case 0:
                    Console.Write("1"); break;
                case 1:
                    Console.Write("2");break;
                case 2:
                    Console.Write("3");break;
                case 3:
                    Console.Write("4");break;
                case 4:
                    Console.Write("5");break;
                case 5:
                    Console.Write("6");break;
                case 6:
                    Console.Write("7");break;
                case 7:
                    Console.Write("8");break;
                case 8:
                    Console.Write("9");break;
            }
        }
        public static void ally()
        {
            var rand = myRandom.Next(0, 3);
            switch (rand)
            {
                case 0:
                    Console.Write("Роза"); break;
                case 1:
                    Console.Write("Джек");break;
                case 2:
                    Console.Write("Эми");break;
            }
        }
        public static void item()
        {
            var rand = myRandom.Next(0, 2);
            switch (rand)
            {
                case 0:
                    Console.Write("Бабочка"); break;
                case 1:
                    Console.Write("Феска");break;
            }
        }
        public static void Main(string[] args)
        {
            sentense();
            Console.ReadKey();
        }
    }
}