using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//kodlara ait kütüphaneler

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("*****Yemek Kategorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorileri*****");
            #endregion

            #region String Değişkenler

            //string 
            //değişkenin_türü değişken_adı;

            //string name;
            //name = "Merve";
            //Console.Write(name);

            //string customerName; //camelcase adlandırma
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Merve";
            //customerSurname = "Arpacıoğlu";
            //customerPhone = "+90 446 888 99 77";
            //customerEmail = "info@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("****Rezervasyon Kartı");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri:"+customerName + " " + customerSurname);
            //Console.WriteLine("İletişim " + customerPhone);
            //Console.WriteLine("Email Adresi " + customerEmail);
            //Console.WriteLine("Adres " + district + "/" + city);
            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine();

            //customerName = "İlker";
            //customerSurname = "Türk";
            //customerPhone = "+90 444 444 69 96";
            //customerEmail = "info2@gamil.com";
            //district = "Bakırköy";
            //city = "İstanbul";


            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim " + customerPhone);
            //Console.WriteLine("Email Adresi " + customerEmail);
            //Console.WriteLine("Adres " + district + "/" + city);
            //Console.WriteLine("----------------------------------------------");







            #endregion

            #region Int Değişkenler
            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("****Restoran Menü Fiyatı****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice; 

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0; 
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokeCount;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı:"+totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı:"+totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı:"+totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı:"+totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı:"+totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı:"+totalLemonadePrice + "TL");

            Console.WriteLine();
            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam ödenecek tutar :"+ totalPrice + "TL");
            #endregion


            Console.Read();
        }
    }
}

//Yazdırma Komutları
