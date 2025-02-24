using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //Döngüler 1+2+3+4+7

            /*
             * For(x;y;z)
             * x:başlangıç
             * y:bitiş
             * z:artış - azalış
             */

            //int i;
            //for (i = 1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim kampı");
            //}

            //for (int i = 1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i =3;i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen ekrana yazılması istediğiniz adedi giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());
            //for(int i =1;i<=finishValue;i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet !");
            //}



            #endregion

            #region For Döngüsü İle Karar Yapıları
            //for (int i =0 ; i<= 100; i++)
            //{
            //    if(i % 5  ==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for(int i =1 ; i<= 10; i++) 
            //{
            //    totalValue += i;

            //}

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        totalValue += i;
            //    }
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 21; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count += 1;
            //    }
            //}
            //Console.WriteLine(count);

            //1 bakteri

            //int totalBacterium = 1;
            //for (int i = 1; i<=24; i++) 
            // {
            //    totalBacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda : " + totalBacterium);

            // }



            #endregion

            #region While Döngüsü 
            //şart sağlandığı müddetçe anlamına gelir

            //while(şart)
            //{
            //işlemler
            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;
            //while (i <= 10)   
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);




            #endregion

            #region Ornek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

          
            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz : ");
            //int sayi =int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;

            //ones = sayi % 10;
            //hundred = sayi / 100;
            //tens = (sayi % 100) / 10;

            //Console.WriteLine("Sayının birler basamağı : " + ones);
            //Console.WriteLine("Sayının onlar basamağı : " + tens);
            //Console.WriteLine("Sayının yüzler basamağı : " + hundred );

            //sum = ones + tens + hundred;
            //Console.Write(sayi + " Sayısının basamakları toplamı : " + sum );


            #endregion

            Console.Read();
        }
    }
}
