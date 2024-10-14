using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _01_mainsubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma komutları
            //Console.Write("bu ikinci canım");
            //Console.Write("ders tehsbdıjaoıds");
            //Console.Write("jesrdhfjskslşdşlfkj");
            //Console.Read();

            //Console.Write("****** yemek menüsü ******");
            //Console.Write();
            //Console.Write("1 çorba");
            //Console.Write("2 ekşi");
            //Console.Write("3 tuzlu");
            //Console.Write("4 tatlı");
            #endregion




            #region Değişkenler
            //string name;
            //name = "rumeysa";
            //Console.Write(name);
            //Console.Read();

            //string customerName, surname, emaile, district, city, phoneNumber;
            //customerName = "rumeysa";
            //surname = "varlı";
            //emaile = "yok@gmail.com";
            //district = "alanya";
            //city = "antalya";
            //phoneNumber = "02895663256255";
            //Console.Write("name:" + customerName + "surname:" + surname);
            //Console.Write("email:" + emaile);
            //Console.Write("yaşadığı yer:" + district + "  " + city);
            //Console.Write("numarası:" + phoneNumber);





            //string name;
            //name = "ali";
            //Console.Write(name);
            //name = "rum";
            //Console.Write(name);
            //burada artık name rum olur. codları yukardan aşşağı okudu için ali yi de yazdırır.


            #endregion

            #region İnt değişkenler
            // integer tam sayılarda kullanılıyor.ve değer atmak istediğinde önüne int yazmalısın.

            //int Number = 24;
            //Console.Write(Number);
            //Console.Read();


            //****************************************************************
            //AŞAGIDA MENÜ VE FİYAT BULMA YAPTIN



            //int hamburgerPrice, limonadePrice, pizzaPrice, totalPrice;
            //hamburgerPrice = 300;
            //limonadePrice = 35;
            //pizzaPrice = 200;


            //Console.Write("*****menü ve fiyatlar*****");
            //Console.Write();
            //Console.Write("hamburger:" + hamburgerPrice);
            //Console.Write("pizza:" + pizzaPrice);
            //Console.Write("limonata:" + limonadePrice);
            //Console.Write("*****menü ve fiyatlar*****");


            //int hamburgerCount = 3;
            //int limonadeCount = 3;
            //int pizzaCount = 1;
            //totalPrice = hamburgerPrice*hamburgerCount+limonadeCount*limonadePrice+pizzaCount*pizzaPrice;
            //Console.Write("toplam tutar:" + totalPrice + "tl");
            //Console.Read();









            #endregion

            #region double değişkenler
            //double applePrice, tomatoPrice, bananaPrice;

            //applePrice = 25.4;
            //tomatoPrice = 14.75;
            //bananaPrice = 23.45;

            //double appleGram, tomatoGram, bananaGram;
            //appleGram = 1255;
            //tomatoGram = 1235;
            //bananaGram = 0.250;

            //double appleTotalPrıce;
            //double tomatoTotalPrıce;
            //double bananaTotalPrıce;

            //appleTotalPrıce = applePrice * appleGram;
            //tomatoTotalPrıce = tomatoGram * tomatoPrice;
            //bananaTotalPrıce = bananaGram * bananaPrice;

            //Console.Write("*****manavdaki ürünler ve fiyatları*****");
            //Console.Write();
            //Console.Write("----------elmanın fiyatı:" + applePrice);
            //Console.Write("----------domatesin fiyatı:" + tomatoPrice);
            //Console.Write("----------muzun fiyatı fiyatı:" + bananaPrice);


            //Console.Write("elmanın toplam fiyatı:" + appleTotalPrıce);
            //Console.Write("domatesin toplam fiyatı:" + tomatoTotalPrıce);
            //Console.Write("elmanın toplam fiyatı:" + bananaTotalPrıce);
            //double totalPrice;
            //totalPrice = appleTotalPrıce + tomatoTotalPrıce + bananaTotalPrıce;
            //Console.Write("toplam tutar:" + totalPrice);  //sonuçta kuruş çok büyük çıkıyor onu nasıl tam kısma atacak


            //Console.Read();



            #endregion

            #region char değişkenler

            //char symbul;
            //symbul = 'A';   
            //Console.Write(symbul);
            //Console.Read();













            #endregion

            #region klavye değer atamaları string

            //string name, surname;

            //Console.Write("yolcu adı:");
            //name= Console.ReadLine();
            //Console.Write("yolcu soy adı:");
            //surname= Console.ReadLine();

            //Console.Write("yolcu:"+name+" "+surname);
            //Console.ReadLine();
            #endregion

            #region kalvyeden tam sayı girişleri ve dönüşümler burayı tam anlamadın
            //int tvPrice, phonePrice;

            //tvPrice = 1200;
            //phonePrice = 2000;

            //int tvCount, phoneCount;

            //Console.Write("aldığınız tv sayısı:");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write();

            //Console.Write("aldığınız telefon sayısı:");
            //phoneCount = int.Parse(Console.ReadLine());
            //int totallyPrice;
            //totallyPrice = tvPrice*tvCount + phonePrice*phoneCount;
            //Console.Write("ödenecek toplam para:" + totallyPrice);
            //Console.Read();



            #endregion

            #region kalvye değer atama char neden bilmiyorum cisiyet giriniz gözükmüyor ve burada char sadece tek karakter kabul eder aa yazarsan hata verir

            //char gender; 
            //Console.Write("cisiyet giriniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("girddiğin cinsiyet:" + gender);

            //Console.Read();



            #endregion


            //making decisions karar yapıları
            #region if else

            //Console.Write("şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "ramçook")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else { Console.WriteLine("şifre yanlış"); }
            //Console.Read();




            //int number;
            //Console.Write("sayıyı giriniz:");
            //number = int.Parse(Console.ReadLine());
            //if (number == 12)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}
            //Console.Read();


            //string captiol, country;
            //Console.Write("şehri giriniz:");
            //captiol = Console.ReadLine();
            //Console.Write("ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if (captiol == "antalya" & country == "türkiye") { Console.WriteLine("doğru girdiniz"); }
            //else { Console.WriteLine("yanlış girdiniz"); }
            //Console.Read();



            //Bu bitmedi devam burdan

            //int exam1, exam2, exam3, avarage;
            //Console.Write("1. sınav sonucunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sınav sonucunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. sınav sonucunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması:" + avarage);

            //if (avarage < 50)
            //{
            //    Console.WriteLine("geçemedi");
            //}
            //else
            //{
            //    Console.WriteLine("geçti");
            //} 


            //Console.Read();


            //string ctiy;
            //Console.Write("şehir giriniz: ");
            //ctiy=Console.ReadLine();
            //if (ctiy == "istanbul" | ctiy == "antalya" | ctiy == "elazığ")
            //{
            //    Console.WriteLine("geçerli şehir.");
            //}
            //else { Console.WriteLine("geçersiz işlem"); }
            //Console.Read();


            //string name;
            //Console.Write("kullanıcı adını giriniz:");
            //name= Console.ReadLine();
            //if (name != "rum")
            //{
            //    Console.WriteLine("bu kullanıcı adı geçersiz");
            //}
            //else { Console.WriteLine("giriş başarılı"); }
            //Console.Read();


            #endregion

            #region mod işlemleri

            //int number;
            //Console.Write("lütfen bir sayı giriniz:");
            //number = int.Parse(Console.ReadLine());

            //int result=number%5;

            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region uygulama ama sıkıldın

            //Console.WriteLine("*****yemek menüsü******");
            //Console.WriteLine();

            //string amenuİtem;

            //Console.WriteLine("yemekler");
            //Console.WriteLine("yçorbalar");
            //Console.WriteLine();



            //Console.Write("hangi menüye bakmak istiyorsunuz:");
            //amenuİtem = Console.ReadLine();

            //if (amenuİtem == "ana yemek")
            //{
            //    Console.WriteLine("içli köfte");
            //    Console.WriteLine("barbunya");
            //    Console.WriteLine("kuru fasulye");
            //    Console.WriteLine("mercimek köftesi");
            //    Console.WriteLine("pizza");
            //    Console.WriteLine("tavuk dürüm");
            //}
            //if (amenuİtem == "çorbalar")
            //{
            //    Console.WriteLine("ezo gelin");
            //    Console.WriteLine("mercimek");
            //    Console.WriteLine("domates");
            //    Console.WriteLine("yayla");
            //    Console.WriteLine("yoğurt");
            //}
            //else
            //{
            //    Console.WriteLine("salata");
            //}

            //Console.Read();


            #endregion

            #region  if ler çok olduğunda ve sayıyla gişte ya da sayı yerine başka bir şey yazıp da kullana bilirsin daha konforlu
            //Console.Write("sayı ile görmek istediğiniz ayı yazınız:");
            //int mounthNumber=int.Parse(Console.ReadLine());

            //switch (mounthNumber)
            //{
            //    case 1:Console.WriteLine("ocak");break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    case 7: Console.WriteLine("temmuz"); break;
            //    case 8: Console.WriteLine("ağustos"); break;
            //    case 9: Console.WriteLine("eylül"); break;
            //    case 10: Console.WriteLine("ekim"); break;
            //    case 11: Console.WriteLine("kasım"); break;
            //    case 12: Console.WriteLine("aralık"); break;
            //    default:Console.WriteLine("hatalı giriş"); break;
            //}
            //Console.Read();

            #endregion

            #region switch case hesap makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. sayıyı giriniz:");
            //number1 =int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz:");
            //number2 =int.Parse(Console.ReadLine());

            //Console.Write("yapmak istediğiniz işlemi seçiniz:");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case'+':
            //        result= number2 + number1;
            //        Console.WriteLine("toplam:" + result);
            //        break;
            //    case '-':
            //        result= number2 - number1;
            //        Console.WriteLine("fark:" + result);
            //        break;
            //    case '*':
            //        result= number2 * number1;
            //        Console.WriteLine("çarpımları:" + result);
            //        break;
            //    case '/':
            //        result= number2 / number1;  
            //        Console.WriteLine("bölümleri:" + result);
            //        break;

            //    default: Console.WriteLine("geçersiz işlem");
            //        break;
            //}
            //Console.Read();

















            #endregion



         




















        }





    }




    
}


// yorum satırı 
// ama her satıra yazman lazım
