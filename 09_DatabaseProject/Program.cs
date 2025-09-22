using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 201 - modul 1.ders
            //-----------------------------------

            // Ado.Net

            Console.WriteLine("***** C# Veri Tabanlı Ürün - Kategori Bilgi Siatemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek istediğiniz tablo numarasını getiriniz : ");
            tableNumber=Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");


            // SQL Bağlantısı gerekli / Yapalım

            SqlConnection connection = new SqlConnection("Data Source=NOVA-PC87; initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable ();
            adapter.Fill (dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            connection.Close();

            Console.Read();

        }
    }
}
