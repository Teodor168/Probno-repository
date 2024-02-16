using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chislo ot 0 do 128");
            byte number = byte.Parse(Console.ReadLine());
            Console.WriteLine("dai chislo");
            int num = byte.Parse(Console.ReadLine());
            int counter = 0;
            string container= null;
            //do
            //{

            //    string word = Console.ReadLine();
            //    counter++;
            //    container += word + ", ";
            //} while (counter < num);

            //while (counter < num)
            //{
            //    string word = Console.ReadLine();
            //    counter++;
            //    container += word + "," + " ";
            //}

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                counter++;
                container += word + ", ";
            }
            Console.WriteLine($"broqt na dumite: {counter}");
            Console.WriteLine(container);
        }
    }
}
