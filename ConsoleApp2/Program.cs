using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("E:\\Програмирование\\Text1.txt"))
            {
                char[] delimiters = new char[] { ' ', '\r', '\n' };
                string text = reader.ReadToEnd();
                
                var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                Stopwatch stopwatch1 = new Stopwatch();

                stopwatch1.Start();
                List<string> list = new List<string>(words);
                stopwatch1.Stop();

                Stopwatch stopwatch2 = new Stopwatch();

                stopwatch2.Start();
                LinkedList<string> linkedlist = new LinkedList<string>(words);
                stopwatch2.Stop();

                Console.WriteLine($"Время первого теста: {stopwatch1.ElapsedMilliseconds}");
                Console.WriteLine($"Время второго теста: {stopwatch2.ElapsedMilliseconds}");
            }
        }
        
    }
}