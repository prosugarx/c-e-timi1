using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_foreachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü

            //string[] cities = { "budapeşte", "istanbul", "ankara", "antalya" };
            //foreach (string city in cities) 
            //{
            //    Console.WriteLine(city);
            //}


            //çift sayıları kolayca yazdırabilirsin
            //int[] numbers = { 12, 25, 46, 85, 79, 86, 26, 25, 242365, 18596, 145, 36, 24853, };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 12, 25, 46, 85, 79, 86, 26, 25, 242365, 18596, 145, 36, 24853, };
            //int i = 0;

            //foreach (int number in numbers)
            //{
            //    i += number;
            //}
            //Console.WriteLine(i);



            //List<int> numbers = new List<int>()
            //{ 
            //  1,2,3,4,5,8,
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            string word;
            Console.Write("bir kelime ya da cümle giriniz:");
            word = Console.ReadLine();
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }






            #endregion
            Console.ReadLine();







        }
    }
}
