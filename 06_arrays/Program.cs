using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örenekleri
            //string[] city = new string[3];
            //city[0] = "istanbul";
            //city[1] = "ankara";
            //city[2] = "antalya";
            //Console.WriteLine(city[2]);


            //int[] number = new int[10];
            //number[0] = 1;
            //number[1] = 2;
            //number[2] = 3;
            //number[7] = 4;
            //Console.WriteLine(number[4]);


            //string[] city = { "ankara", "izmir", "istanbul", "antalya" };
            //Console.WriteLine(city[2]);

            #endregion

            #region dizideki tüm elemanları listeleme
            //string[] colors = { "mavi", "mor", "kızrmızı", "yeşil", "sarı", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] number = { 1, 2, 3,25,47,96,123,65,87 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //char[] symbol = { 'A', 's', 'c', 'b' };
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}


            #endregion

            #region en büyük sayıyı bulma

            //int[] MyArreys = { 12, 25, 46, 85, 97, 369, 586, 2354, 78956, 15263, 48956, 756 };
            //int bigNumber = MyArreys[0];
            //for (int i = 0; i < MyArreys.Length; i++) 
            //{
            //    if (MyArreys[i] > bigNumber)
            //    {
            //        bigNumber=MyArreys[i];

            //    }
            //}
            //Console.WriteLine("en büyük değer:" + bigNumber);



            #endregion

            #region length: uzunluk  sort:sıralar küçükten büyüğe

            //int[] numbers = { 23, 56, 89, 147, 82, 23, 125, 542, 365, 532, 23, 363, 2533, 25 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine(numbers.Length);





            #endregion

            #region dizi metotları
            ////string[] name = { "ali", "ayşe", "mehmet", "kenan", "arda" };
            ////int index = Array.IndexOf(name, "kenan");
            ////Console.WriteLine(index);

            //int[] numbers = { 23, 56, 89, 147, 82, 23, 125, 542, 365, 532, 23, 363, 2533, 25 };
            //Console.WriteLine("dizinin en büyük elemanı:" + numbers.Max() + " dizinin en küçük elemanı:" + numbers.Min());


            #endregion

            #region kullanıcıdan değer alma bu biraz kafa karıştırdı

            //string[] ctiys = new string[5];

            //for (int i = 0; i < ctiys.Length; i++)
            //{
            //    Console.Write($"lütfen{i + 1}. değeri giriniz:");
            //    ctiys[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < ctiys.Length; i++)
            //{
            //    Console.WriteLine(ctiys[i]);
            //}



            #endregion

            #region sayıların toplamı

            //int[] number = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region tek çift ayrı ayrı listeleme burasını ertlemek durumunda kaldın

            //int[] number = { 20, 86, 45, 67, 79, 2631, 18, 14, 17, 39, 35 };


           // for (int i = 0; i < number.Length; i++)
           // {
           //     if (number[i] % 2 == 0)
           //     {
                    

           //     }
           //     Console.WriteLine("çift sayılar:" + number[i]);
           // }
           //for(int i = 0; i < number.Length; i++)
           // {
           //     if (number[i] % 2 != 0)
           //     {
           //         Console.WriteLine("tek sayılar:" + number[i]);
           //     }
           // }



            #endregion

            Console.ReadLine();
        }
        
    }
}
