using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _08_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metodu aynı şeyi yazmak için onlarca kod yazzmana gerek yok void geriye değer döndürmeyen

            //void CustumerName()
            //{
            //    Console.WriteLine("ali");
            //    Console.WriteLine("aleyna");
            //    Console.WriteLine("aliye");
            //    Console.WriteLine("alihandro");
            //}

            //CustumerName();
            //CustumerName();
            //CustumerName();
            //CustumerName();



            //void sum()
            //{
            //   int x = 2;
            //   int y = 5;
            //   int r = x + y;
            //   Console.WriteLine(r);
            //}
            //sum();

            #endregion

            #region bunun sayesinde sadece isim alarak bir sürü müşteri adı yazabilirsin

            //void CustumerCard(string name, string surName)
            //{
            //    Console.WriteLine("müşteri:" + name + " " + surName);

            //}
            //CustumerCard("rumeysa"," varlı");
            //CustumerCard("nisa"," varlı");
            //CustumerCard("kenan"," varlı");
            //CustumerCard("remziye"," varlı");
            //CustumerCard("vildan"," varlı");

            #endregion

            #region bunu kendi kendine yaptın tebrikkk


            //Console.Write("lütfen müşterinin  adını  giriniz:");
            //string cName=Console.ReadLine();
            //Console.Write("lütfen müşterinin soy adını  giriniz:");
            //string cSurName=Console.ReadLine();
            //void CustumerCard(string name, string surName)
            //{
            //    Console.WriteLine("müşteri:" + name + " " + surName);

            //}

            //CustumerCard(cName,cSurName);





            #endregion

            #region geriye değer döndürmeyen int parametreli metodlar

            //void sum(int number1, int number2, int number3)
            //{
            //    int result =  number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(7,6,58);






            #endregion

            #region geriye değer döndüren parametre biraz sıkıntı

            //string studentName()
            //{
            //    return "rumeysa  varlı";        
            //}
            //studentName();

            //string studentCard()
            //{
            //    string name = "rumeysa";
            //    string surname = "varlı";
            //    return (name + " " + surname);
            //}
            //Console.WriteLine(studentCard());




            #endregion

            #region geriye değer döndüren string parametreli metodlar

            //string CountryCard(string country, string capital, string color)
            //{
            //    return "ülke: " + country + " başkent: " + capital + " renk: " + color;
            //}

            //string x, y, z;

            //Console.Write("ülke adını giriniz:");
            //x = Console.ReadLine();
            //Console.Write("başkent adını giriniz:");
            //y = Console.ReadLine();
            //Console.Write("ülkenin bayrak rengini giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.Write(CountryCard(" italya "," roma "," kırmızı-beyaz "));


            #endregion

            #region geriye değer döndüre int parametreli metodlar tam olarak nerde işe yarayacağını kestiremiyorum

            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(25, 45));
            //Console.WriteLine(sum(65, 85));
            //Console.WriteLine(sum(16, 74));
            //Console.WriteLine(sum(78, 436));
            #endregion

            #region çok uzttım yaaa ama tek başıma yaptım

            //string examNote(string studentName, string studentSurName, int exam1, int exam2, int exam3)
            //{
            //    int result=(exam1 + exam2 + exam3)/3 ;

            //    return studentName + studentSurName +  " adlı öğrencinin aldığı not:" + result ;
            //}
            //string a, b;
            //int x,y,z = 0 ;
            //Console.Write("öğrencinin adını giriniz:");
            //a=Console.ReadLine(); 
            //Console.Write("öğrencinin soy adını giriniz:");
            //b=Console.ReadLine();
            //Console.Write( "1. sınav notunu giriniz:");
            //x= int.Parse(Console.ReadLine());
            //Console.Write("2. sınav notunu giriniz:");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("3. sınav notunu giriniz:");
            //z = int.Parse(Console.ReadLine());

            //Console.Write(examNote(a,b,x,y,z));



            #endregion




            Console.ReadLine();



        }
    }
}
