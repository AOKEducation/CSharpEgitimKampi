using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] cities= new string[5];
            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";
            //cities[2] = "İzmir";
            //cities[3] = "Bursa";
            //cities[4] = "Antalya";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[4] = 748;
            //numbers[5] = 48;
            //numbers[6] = 48;
            //Console.WriteLine(numbers[5]);


            #endregion

            #region Dizideki tüm elemanları listeleme

            // -->
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            // -->
            //int[] numbers = { 12, 45, 78, 32, 5, 89, 63, 47, 26, 10, 7425, 2365, 685 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            // -->
            //char[] symbols = {'a','b','c','2','3','4','5','6','7','8','9','0','!','@','#','$','%','^','&','*','(',')' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //        Console.WriteLine(numbers[i]);
            //}



            // -->
            //int[] myArray = { 12, 45, 78, 32, 5, 89, 63, 47, 26, 10, 7425, 2365, 685 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}


            //string[] persons = { "Ali", "Veli", "Ayşe", "Fatma", "Ahmet", "Mehmet", "Canan", "Ceyda", "Deniz", "Hüseyin" };
            //Console.WriteLine(persons.Length ); ;


            //int[] numbers = { 12, 45, 78, 32, 5, 89, 63, 47, 26, 10, 7425, 2365, 685 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}   

            #endregion

            #region Dizi Metodları
            //string[] customers = { "Ali", "Veli", "Ayşe", "Fatma", "Ahmet", "Mehmet", "Canan", "Ceyda", "Deniz", "Hüseyin" };    
            //int index= Array.IndexOf(customers, "Canan");
            //Console.WriteLine(index);

            //int[] numbers = { 45,85,96,36,74,10,25,22,36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max()+"\nDizinin en küçük elemanı : " +numbers.Min());

            #endregion


            #region Kullanıcıdan değer alma


            //string[] cities= new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    //Console.Write("Lütfen {0}. şehir ismini giriniz: ", i + 1);
            //    Console.Write($"Lütfen {i+1}. şehir ismini giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("Girmiş olduğunuz şehirler sırasıyla aşağıdaki gibidir:");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length ; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
              



            int[] numbers = { 21,42,33,54,55,66,897,475,29,330,332 };

            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion



            Console.Read();

        }
    }
}
