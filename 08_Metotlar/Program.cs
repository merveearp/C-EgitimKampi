using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye Değer Döndürmeyen Metotlar
            // _____Listele ,Ekle,Silme,Güncelleme
            //void olarak tanımlanır.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("AYşe Yılmaz");
            //    Console.WriteLine("İlker Türk");
            //    Console.WriteLine("Merve Arpacıoğlu");

            //}

            //CustomerList();
            //void Sum()
            //{
            //    int x = 4;
            //    int y = 5;
            //    Console.WriteLine(x + y);
            //}

            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void WriteMethot(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethot("Mehmet Yıldırım");
            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri:" + name + " " + surName);
            //}
            //CustomerCard("Ayşe", "Kaya");



            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2 ,int number3)
            //{
            //    int result =number1+ number2+number3;
            //    Console.WriteLine(result);

            //}
            //Sum(4,5,6);

            #endregion

            #region Geriye Değer Döndüren Metotlar
            //Return kullanılır

            //string CustomerName()
            //{
            //    return "Buse Yılmaz";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name ="Ali";
            //    string surname = "Yıldız";

            //    return name+" " + surname;  
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Paremetreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{

            //    string cardInfo=" Ülke :"+countryName+" - Başkent :"+capital+" - Bayrak Rengi :" + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke adını giriniz :");
            //x= Console.ReadLine();
            //Console.WriteLine("Başkenti giriniz :");
            //y = Console.ReadLine();
            //Console.WriteLine("Bayrak rengini giriniz :");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));



            #endregion

            #region Geriye Değer Döndüren Int Paremetreli Metotlar

            //int Sum(int number1 ,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine( Sum(45 , 25));
            //Console.WriteLine(Sum(205, 35));
            //Console.WriteLine(Sum(42, 45));
            //Console.WriteLine(Sum(36, 75));


            #endregion

            #region Örnek Uygulama 
            //string ExampleResult(string student,int exam1 ,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 +  exam3)/3;
            //    if(result >=50)
            //    {
            //        return student + " isimli Öğrenci dersi geçti." + "Ortalaması:" + result ;
            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci ders tekrarı almalıdır." + "Ortalaması:" +result;
            //    }

            //}
            //Console.WriteLine(ExampleResult("Ayşe",45,85,25));

            #endregion


            Console.Read();
        }
    }
}
