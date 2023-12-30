using System;

namespace ConsoleApp2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] people = new User[]
            {
                new User("euw3uif", "Artem", true),
                new User("wiobnfw", "Sofy", true),
                new User("wfne", "Liara", false)
            };
            foreach (var item in people)
            {
                Console.WriteLine($"Здравствуй, {item.Name}!");
                if (!item.IsPremium)
                {
                    ShowAds();
                }
            }
        }
        /// <summary>
        /// Реклама
        /// </summary>
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}