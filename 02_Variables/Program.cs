using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("****FİYAT LİSTESİ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice=14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 55;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı :"+ applePrice+ "TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı :"+ orangePrice +"TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı :"+ strawberryPrice+"TL");
            //Console.WriteLine("---- Patates Birim Fiyatı :"+ potato +"TL");
            //Console.WriteLine("---- Domates Birim Fiyatı :"+ tomato +"TL");

            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potato;
            //double tomatoTotalPrice = tomatoGram * tomato;
            //Console.WriteLine("Alınan Ürün :Elma-" + "Birim Fiyat = "+ applePrice +" - Gramaj : "+ appleGram+ "-Toplam Tutar = " +appleTotalPrice);
            //Console.WriteLine("Alınan Ürün :Portakal-" + "Birim Fiyat = "+ orangePrice +" - Gramaj : "+ orangeGram+ "-Toplam Tutar = " +orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün :Çilek-" + "Birim Fiyat = "+ strawberryPrice +" - Gramaj : "+ strawberryGram+ "-Toplam Tutar = " +strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün :Patates-" + "Birim Fiyat = "+ potato +" - Gramaj : "+ potatoGram+ "-Toplam Tutar = " +potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün :Domates-" + "Birim Fiyat = "+ tomato +" - Gramaj : "+ tomatoGram+ "-Toplam Tutar = " +tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutarı = " + shoppingTotalPrice + "TL");
            #endregion

            #region Char Değişkenler

            ////ABCDEFGH

            ////Char değişkenler ' tek tırnakla tanımlanır

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("*****CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname =Console.ReadLine();

            //Console.Write("İlçe Bilgisi :");
            //passengerDistrict =Console.ReadLine();

            //Console.Write("İl Bilgisi :");
            //passengerCity =Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi :");
            //passengerAge =Console.ReadLine();

            //Console.Write("Yolcu Kimlik Bilgisi :");
            //passengerIdentityNumber =Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No :"+passengerIdentityNumber+ " Yolcu Ad -Soyad : " +  passengerName + "-" + passengerSurname+ " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);





            #endregion

            #region Klavyeden Tamsayı Girişleri ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 1200;

            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız pc sayısını giriniz : ");
            //computerCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz : ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödenmesi gereken tutar = "+ totalPrice + "TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3 ,result;
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ders Not Ortalaması = " + result);


            #endregion

            #region Klavyeden Karakter Girişleri 

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);
            #endregion


            
            Console.Read();
        }
    }
}
