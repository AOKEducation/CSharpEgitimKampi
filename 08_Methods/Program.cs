using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // ()
            // Geriye Değer Döndürmeyen Metotlar
            // Customer --> Listele, Ekle, sil, guncelle
            // Void


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("MerveÇınar");

            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Abi");


            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Musteri : " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe", "Kaya");





            #endregion

            #region Geriye Değer döndürmeyen Int Parametreli metotlar
            //void Sum (int number1, int number2, int number3)
            //{
            //    int result = number1 + number2+number3;
            //    Console.WriteLine(result);

            //}
            //Sum(12, 43, 13);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{

            //    return "Duru Yıldız";

            //}
            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());


            #endregion
             
            #region Geriye değer döndüren parametreli metotlar

            //string CountryCArd(string CountryName, string capital,string flagColor)
            //{
            //    string cardInfo= "Ülke : " + CountryName+" - Başkenti : "+capital+" - Bayrak Rengi :"+flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Baş :");
            //x=Console.ReadLine();
            //Console.Write("Ülke Başkenti :");
            //y = Console.ReadLine();
            //Console.Write("Ülke Bayrak Rengi :");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCArd(x, y, z));


            //Console.Write(CountryCArd("Türkiye", "Ankara", "Kırmızı Beyaz"));

            #endregion

            #region Geriye değer döndüren Int parametreli metotlar

            //int Sum (int number1, int number2)
            //{

            //    int result =number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 69));
            //Console.WriteLine(Sum(23, 544));
            //Console.WriteLine(Sum(33, 22));
            //Console.WriteLine(Sum(44, 5555));

            #endregion

            #region Örnek Sınav geçme uygulaması

            string  examResult(string student, int exam1, int exam2, int exam3)
            {

                int result = (exam1 + exam2 + exam3) / 3;

                if (result >=50)
                {
                    return student + " Sınavı Geçti -> Ortalama : "+result;
                }
                else
                {
                    return student + " Başarısız oldu -> Ortalama : " +result ;
                }

            }
            Console.WriteLine(examResult("Ali", 45, 65, 75));
            Console.WriteLine(examResult("Ayşe", 12, 86, 33));
            #endregion  

            Console.Read();
        }
    }
}
