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

            #region foreach Döngüsü

            // Foreeachh (1;2;3;4)

            // 1: Değişken türü
            // 2: Değişken adı
            // 3: In
            // 4: Liste, Koleksiyon,Dizi, Array


            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 12, 45, 78, 32, 5, 89, 63, 47, 26, 10, 7425, 2365, 685 };
            //foreach (int number in numbers)
            //{
            //        Console.WriteLine(number);
            //}
            //// ---
            //Console.WriteLine("********** Çift Sayılar ***************");
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 12, 45, 78, 32, 5, 89, 63, 47, 26, 10, 7425, 2365, 685 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total = total + number;
            //}   
            //Console.WriteLine("Toplam: " + total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,10
            //};
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //                   Console.WriteLine(c);
            //}


            #endregion





            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Sınav Sistemi Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");
            Console.Write("Öğrenci Sayısı : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");


            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string [] studentNames = new string[studentCount];
            double[] studentAverages = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // her öğrenci için 3 sınav notu al
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]}. isimli öğrenci {j+1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topla
                }
                studentAverages[i] = totalExamResult / 3; // ortalama hesapla
            }

            // Öğrenci isimlerini ve not ortalamalarını listele
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Öğrenci Adı: {studentNames[i]}, Not Ortalaması: {studentAverages[i]:F2}");
                // Geçip kalma durumlarını göster
                if (studentAverages[i] >= 50)
                {
                    Console.WriteLine("Durum: Geçti");
                }
                else
                {
                    Console.WriteLine("Durum: Kaldı");
                }
                Console.WriteLine("------------------------------------------------");

            }

            #endregion

            Console.Read();
        }
    }
}
/* 
    101 - Temel syntax konuları
    201 - Algoritme soruları
    301 - SQL - metodlar - sınıflar
    401 - SQL ile kullanım
    501 - Mongo DB
    601 - Tasarım deseni
    701 - API
 */
