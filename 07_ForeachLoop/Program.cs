using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach (1;2;3;4)
            //1-Değişken türü
            //2-Değişken adı
            //3-In
            //4-Liste Koleksiyon Dizi
            //string[] cities = { "Milano", "Roma", "Ankara", "İstanbul", "Varşova" };
            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 75, 87, 98, 45, 11, 24, 37, 84, 55, 67 };
            //foreach(int number in numbers) {
            //    {
            //        Console.WriteLine(number);
            //    }

            //int[] numbers = { 45, 75, 87, 98, 45, 11, 24, 37, 84, 55, 67 };
            //foreach(int number in numbers)
            //{
            //    if(number %2 ==)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 75, 87, 98, 45, 11, 24, 37, 84, 55, 67 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,34,4,5,6,7,8,9,
            //};
            //foreach(int i in numbers)
            //{
            //    Console.Write(i+" ");
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Egitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan alıyoruz
            Console.WriteLine("--------------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            
            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i =0; i< studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

            

                double totalExamResult = 0;
                
                //her öğrenci için 3 sınav notu girişi
                for(int j=0; j<=2; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1} . sınav notunu giriniz :");
                    double value =double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları toplama işlemi         

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult/3 ;

            }

            //Öğrencilerin sınav ortalaması
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");
                //öğrencilerin geçip kalma durumları
                if (studentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti .") ;
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kalmıştır.");

                }
                Console.WriteLine("-------------------------------------------");
            }

            #endregion
            Console.Read();
        }
    }
}
