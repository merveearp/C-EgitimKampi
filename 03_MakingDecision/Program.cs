﻿
using System;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karar Yapıları
            #region If Else 
            //Console.Write("Lütfen şifreyi giriniz : ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd") //eşit mi 
            //{
            //    Console.WriteLine("ŞİFRE DOĞRU");

            //}
            //else
            //{
            //    Console.WriteLine("ŞİFRE YANLIŞ");

            //}
            //string capital, country;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine().ToLower();
            //Console.Write("Ülkeyi Giriniz ");
            //country = Console.ReadLine().ToLower();

            //if(capital =="ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");

            //}
            //else
            //{
            //    Console.WriteLine("Veriler yanlıştır");

            //}

            //int number;
            //Console.Write("Sayıyı giriniz : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) {
            //    Console.WriteLine("Sayi doğru=" + number);
            // }
            //else
            //{
            //    Console.WriteLine("Sayi yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result="HATA";
            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması : " + average);
            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuç vasat!!";

            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "Sonuç Orta!";
            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = "Sonuç İYİ ";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok İYİ";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız : ");
            //city = Console.ReadLine().ToLower();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city =="trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil!!");

            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz : ");
            //string userName = "admin";
            //if (userName != "admin") //admin den farklıysa !=
            //{
            //    Console.WriteLine("Hoşgeldiniz");

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı kullanıcı adı girdiniz .");
            //}


            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz :");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz :");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan :  " + result);

            //Console.Write("Lütfen sayıyı giriniz : ");
            //int number =int.Parse(Console.ReadLine());

            //if(number % 2 ==0)
            //{
            //    Console.Write("Sayı ÇİFTTİR");

            //}
            //else
            //{
            //    Console.Write("Sayı TEKTİR");
            //}



            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz :");

            //team =char.Parse(Console.ReadLine());

            //if(team =='g' | team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team =='f' | team =='F') 
            //{
            //    Console.Write("FENERBAHÇE");
            //}
            //if (team =='b' | team =='B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*****C# EĞİTİM KAMPI RESTORAN");
            //Console.WriteLine("");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Anayemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------");


            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi : ");

            //menuItem = Console.ReadLine();
            //if(menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-----------------Ana Yemekler---------------");


            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Çorbalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin ");
            //    Console.WriteLine("-----------------Çorbalar---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Pizzalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Karışık Pizza");
            //    Console.WriteLine("-----------------Pizzalar---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------İçecekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-----------------İçecekler---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Tatlılar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-----------------Tatlılar---------------");
            //    Console.WriteLine();
            //}




            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay girişi yapınız : ");
            //int monthNumber =int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1 , number2 , result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz :");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz :");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz Sembolü Giriniz :");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplam = "+result);
            //        break;
            //    case '-':
            //        result=number1 - number2;
            //        Console.WriteLine("Fark = "+result);
            //        break;
            //    case '*':
            //        result=number1 * number2;
            //        Console.WriteLine("Çarpma = "+result);
            //        break;
            //    case '/':
            //        result=number1 / number2;
            //        Console.WriteLine("Bölme = "+result);
            //        break;
            //}


            #endregion

            Console.Read();
        }
    }
}
