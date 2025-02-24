using System;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //aynı veri tipinde çok ayıda veeriyi tutmak için tanımlanan ifadelerdir.
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Eleman sayısı];


            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Kahire";
            //cities[2] = "Münich";
            //cities[3] = "Üsküp";
            //cities[4] = "BudaPeşte";

            //Console.WriteLine(cities[3]);

            //int[] values = new int[10];
            //values[0] = 54;
            //values[1] = 44;
            //values[2] = 34;
            //values[3] = 24;

            //Console.WriteLine(values[5]);

            //string[] cities = {"Prag", "Bursa", "Ankara","Atina", "Roma"};
            //Console.WriteLine(cities[4]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Pembe", "Mavi", "Turkuaz","Mor" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 520, 47, 789, 54, 87, 358, 124, 101, 874, 654, 99, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] %3 ==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 87, 89, 56, 44, 25, 53, 52, 78, 64 };
            //int maxNumber=myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //    Console.WriteLine(maxNumber);
            //}

            //string[] persons = { "Ali", "Buse", "Cem", "İLker", "Deniz", "Merve" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 54, 78, 25, 54, 87, 32, 15, };
            //Array.Sort(numbers); //küçüğkten büyüğe sıralama 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Array.Reverse(numbers); //diziyi tersten sıralıyor
            //for(int i =0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlar

            //string[] customers = { "Buse", "Ayşegül", "Merve", "Berra", "Bahar", "Berkay", "Utku", "Ediz" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);
            //index sırasını söylüyor

            //int[] numbers = { 15, 42, 78, 9, 58, 55, 65,45,89,87,99,101 };
            //Console.WriteLine("Dizinin En büyük Elemanı : " + numbers.Max() + " || Dizinin En Küçük Elemanı : " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma 

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.şehrini giriniz:  ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine("-------------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 7, 8, 9, 4, 5, 8, 10, 13, 12, 15, 16 };
            //Console.WriteLine("Çift Sayılar : ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion





            Console.Read();

        }
    }
}
 